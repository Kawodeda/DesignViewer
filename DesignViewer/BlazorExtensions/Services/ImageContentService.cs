using BlazorExtensions.Services.Exceptions;
using Microsoft.JSInterop;
using Model.Design.Math;

namespace BlazorExtensions.Services
{
    public class ImageContentService : IImageContentService
    {
        private readonly IAssetService _assetService;
        private readonly IJsModulesProvider _jsModulesProvider;
        private readonly Dictionary<string, ImageContent> _images = new Dictionary<string, ImageContent>();
        private readonly ISet<string> _requestedImages = new HashSet<string>();

        private IJSObjectReference? _jsModule;

        public ImageContentService(IAssetService assetService, IJsModulesProvider jsModulesProvider)
        {
            _assetService = assetService;
            _jsModulesProvider = jsModulesProvider;
            InitJsModule();
        }

        public ImageContent? GetImageContent(string storageId)
        {
            if (_images.ContainsKey(storageId))
            {
                return _images[storageId];
            }

            RequestImage(storageId);

            return null;
        }

        private void RequestImage(string storageId)
        {
            if (!_requestedImages.Add(storageId))
            {
                return;
            }

            _assetService.GetAssetAsync(storageId)
                .ContinueWith(async assetTask =>
                {
                    try
                    {
                        using Stream asset = assetTask.Result;
                        ImageContent? image = await CreateImageContentAsync(asset);

                        _images.Add(storageId, image);
                    }
                    catch
                    {
                        throw new ImageContentLoadingException("Could not load image content", storageId);
                    }
                    finally
                    {
                        _requestedImages.Remove(storageId);
                    }
                });
        }

        private async Task<ImageContent> CreateImageContentAsync(Stream content)
        {
            var htmlImage =  await _jsModule!.InvokeAsync<IJSObjectReference>(
                "getHtmlImage",
                await ExtractBytesAsync(content));

            float width = await _jsModule!.InvokeAsync<float>("getImageWidth", htmlImage);
            float height = await _jsModule!.InvokeAsync<float>("getImageHeight", htmlImage);

            if (htmlImage == null)
            {
                throw new ImageContentLoadingException();
            }

            return new ImageContent(htmlImage, new Size(width, height));
        }

        private async Task<byte[]> ExtractBytesAsync(Stream data)
        {
            using var memoryStream = new MemoryStream();
            await data.CopyToAsync(memoryStream);

            return memoryStream.ToArray();
        }

        private void InitJsModule()
        {
            if (_jsModulesProvider.IsInitialized)
            {
                _jsModule = _jsModulesProvider.ImageContentService;
            }

            _jsModulesProvider.Initialized += (sender, args) =>
            {
                _jsModule = _jsModulesProvider.ImageContentService;
            };
        }
    }
}
