using System.IO.Abstractions;
using DesignViewer.Server.Dtos;
using DesignViewer.Server.Options;
using DesignViewer.Server.Utils;
using Microsoft.Extensions.Options;

namespace DesignViewer.Server.Services.FileStorage
{
    public class AssetFileStorageService : IAssetStorageService
    {
        private readonly AssetsStorageOptions _options;
        private readonly IFileStorageService _fileStorageService;
        private readonly IContentTypeService _contentTypeService;

        public AssetFileStorageService(
            IOptions<AssetsStorageOptions> options, 
            IFileStorageService fileStorageService,
            IContentTypeService contentTypeService)
        {
            _options = options.Value;
            _fileStorageService = fileStorageService;
            _contentTypeService = contentTypeService;
        }

        public IEnumerable<AssetDto> ListAssets()
        {
            return GetFileInfos()
                .Select(fileInfo => GetAssetFileInfo(fileInfo));
        }

        public AssetDto GetAssetInfo(string storageId)
        {
            return GetAssetFileInfo(
                _fileStorageService.GetFileInfo(
                    FindAssetFilePath(storageId)));
        }

        public Stream GetAssetContent(string storageId)
        {
            return _fileStorageService.ReadFile(
                FindAssetFilePath(storageId));
        }

        public AssetDto UploadAsset(Stream content, AssetDto assetInfo)
        {
            string path = CreateAssetFilePath(assetInfo);

            IFileInfo info = _fileStorageService.CreateFile(path, content);

            return GetAssetFileInfo(info);
        }

        public AssetDto UpdateAsset(string storageId, Stream content)
        {
            string path = FindAssetFilePath(storageId);

            IFileInfo info = _fileStorageService.UpdateFile(path, content);

            return GetAssetFileInfo(info);
        }

        public void DeleteAsset(string storageId)
        {
            string path = FindAssetFilePath(storageId);

            _fileStorageService.DeleteFile(path);
        }

        private string FindAssetFilePath(string storageId)
        {
            IEnumerable<IFileInfo> files = GetFileInfos();
            IFileInfo? file = files.FirstOrDefault(info =>
                Path.GetFileNameWithoutExtension(info.FullName) == storageId);
            if (file == null)
            {
                throw new FileNotFoundException();
            }

            return file.FullName;
        }

        private string CreateAssetFilePath(AssetDto assetInfo)
        {
            return Path.Combine(_options.ImagesPath, $"{assetInfo.StorageId}{GetExtension(assetInfo.Type)}");
        }

        private AssetDto GetAssetFileInfo(IFileInfo fileInfo)
        {
            return new AssetDto
            {
                StorageId = Path.GetFileNameWithoutExtension(fileInfo.FullName),
                Type = GetContentType(fileInfo.Name),
                Size = fileInfo.Length
            };
        }

        private IEnumerable<IFileInfo> GetFileInfos()
        {
            var searchPatterns = _options.ImagesExtensions
                .Select(extension => PathUtils.GetSearchPattern(extension));

            return _fileStorageService.GetFileInfos(_options.ImagesPath, searchPatterns);
        }

        private string GetContentType(string subpath)
        {
            string? result;
            if (_contentTypeService.TryGetContentType(subpath, out result))
            {
                return result;
            }

            return string.Empty;
        }

        private string GetExtension(string contentType)
        {
            string? result;
            if (_contentTypeService.TryGetExtension(contentType, out result))
            {
                return result;
            }

            return _options.DefaultImageExtension;
        }
    }
}