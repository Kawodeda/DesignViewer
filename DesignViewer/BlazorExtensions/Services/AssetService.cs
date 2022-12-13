using ApiClient;
using BlazorExtensions.Services.Exceptions;
using System.Net;

namespace BlazorExtensions.Services
{
    public class AssetService : IAssetService
    {
        private readonly IAssetsApiClient _assetsApiClient;
        private readonly Dictionary<string, Stream> _assets = new Dictionary<string, Stream>();

        public AssetService(IAssetsApiClient assetsApiClient)
        {
            _assetsApiClient = assetsApiClient;
        }

        public async Task<Stream> GetAssetAsync(string storageId)
        {
            if (!_assets.ContainsKey(storageId))
            {
                await RequestAssetAsync(storageId);
            }

            return CopyData(_assets[storageId]);
        }

        public async Task RequestAssetAsync(string storageId)
        {
            try
            {
                using FileResponse response = await _assetsApiClient.GetAssetContnetAsync(storageId);

                _assets.Add(storageId, CopyData(response.Stream));
            }
            catch (ApiException exception)
            {
                if (exception.StatusCode == (int)HttpStatusCode.NotFound)
                {
                    throw new AssetNotFoundException(storageId, $"Could not found requested asset with storageId: {storageId}");
                }

                throw new AssetLoadingException(storageId, $"Could not load requested asset with storageId: {storageId}");
            }
        }

        private Stream CopyData(Stream source)
        {
            var result = new MemoryStream();
            source.Position = 0;
            source.CopyTo(result);
            result.Position = 0;

            return result;
        }
    }
}
