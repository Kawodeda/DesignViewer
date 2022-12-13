using DesignViewer.Server.Dtos;
using DesignViewer.Server.Exceptions;

namespace DesignViewer.Server.Services
{
    public interface IAssetStorageService
    {
        /// <exception cref="FileAlreadyExistException"></exception>
        AssetDto UploadAsset(Stream content, AssetDto assetInfo);

        IEnumerable<AssetDto> ListAssets();

        /// <exception cref="FileNotFoundException"></exception>
        AssetDto GetAssetInfo(string storageId);

        /// <exception cref="FileNotFoundException"></exception>
        Stream GetAssetContent(string storageId);

        /// <exception cref="FileNotFoundException"></exception>
        AssetDto UpdateAsset(string storageId, Stream content);

        /// <exception cref="FileNotFoundException"></exception>
        void DeleteAsset(string storageId);
    }
}
