using DesignViewer.Server.Dtos;

namespace DesignViewer.Server.Services
{
    public interface IAssetStorageService
    {
        AssetDto UploadAsset(Stream content, AssetDto assetInfo);

        IEnumerable<AssetDto> ListAssets();

        AssetDto GetAssetInfo(string storageId);

        Stream GetAssetContent(string storageId);

        AssetDto UpdateAsset(string storageId, Stream content);

        void DeleteAsset(string storageId);
    }
}
