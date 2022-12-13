using System.IO.Abstractions;
using DesignViewer.Server.Dtos;
using DesignViewer.Server.Options;
using DesignViewer.Server.Utils;
using Microsoft.Extensions.Options;

namespace DesignViewer.Server.Services.FileStorage
{
    public class DesignFileStorageService : IDesignStorageService
    {
        private readonly DesignsStorageOptions _options;
        private readonly INameGeneratorService _nameGeneratorService;
        private readonly IFileStorageService _fileStorageService;

        public DesignFileStorageService(
            IOptions<DesignsStorageOptions> options,
            IFileStorageService fileStorageService,
            INameGeneratorService nameGeneratorService)
        {
            _options = options.Value;
            _fileStorageService = fileStorageService;
            _nameGeneratorService = nameGeneratorService;
        }

        public DesignDto UploadDesign(Stream content)
        {
            string filename = _nameGeneratorService.Generate("design");

            return UploadDesign(content, filename);
        }

        public DesignDto UploadDesign(Stream content, string name)
        {
            string path = GetPath(name);

            IFileInfo info = _fileStorageService.CreateFile(path, content);

            return GetDesignFileInfo(info);
        }

        public DesignDto GetDesignInfo(string name)
        {
            string path = GetPath(name);

            return GetDesignFileInfo(
                _fileStorageService.GetFileInfo(path));
        }

        public Stream GetDesignContent(string name)
        {
            string path = GetPath(name);

            return _fileStorageService.ReadFile(path);
        }

        public IEnumerable<DesignDto> ListDesigns()
        {
            return _fileStorageService.GetFileInfos(_options.Path, PathUtils.GetSearchPattern(_options.FileExtension))
                .Select(fileInfo => GetDesignFileInfo(fileInfo));
        }

        public DesignDto UpdateDesign(string name, Stream content)
        {
            string path = GetPath(name);

            IFileInfo info = _fileStorageService.UpdateFile(path, content);

            return new DesignDto()
            {
                Name = Path.GetFileNameWithoutExtension(info.FullName)
            };
        }

        public void DeleteDesign(string name)
        {
            string path = GetPath(name);

            _fileStorageService.DeleteFile(path);
        }

        private string GetPath(string filename)
        {
            return Path.Combine(_options.Path, $"{filename}{_options.FileExtension}");
        }

        private DesignDto GetDesignFileInfo(IFileInfo fileInfo)
        {
            return new DesignDto()
            {
                Name = Path.GetFileNameWithoutExtension(fileInfo.FullName)
            };
        }
    }
}
