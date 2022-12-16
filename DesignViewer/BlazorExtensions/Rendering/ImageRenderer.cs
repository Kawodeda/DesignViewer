using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Models;
using BlazorExtensions.Rendering.Exceptions;
using BlazorExtensions.Services;
using BlazorExtensions.Services.JsInterop;
using Microsoft.JSInterop;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public class ImageRenderer : IImageRenderer
    {
        private readonly IImageContentService _imageContentService;
        private readonly IJsModulesProvider _jsModulesProvider;
        private readonly JsModule _jsModule;

        public ImageRenderer(IImageContentService imageContentService, IJsModulesProvider jsModulesProvider)
        {
            _imageContentService = imageContentService;
            _jsModulesProvider = jsModulesProvider;
            _jsModule = _jsModulesProvider.Rendering;
        }

        public async Task Render(Canvas2DContext context, Image image, Point position, Point scale, ReferencePointType referencePoint = ReferencePointType.TopLeftCorner)
        {
            if (context == null)
            {
                throw new ContextNotSetException();
            }

            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);
            if (imageContent == null)
            {
                return;
            }

            await InitJsModule();
            await _jsModule.Module!.InvokeVoidAsync(
                "drawImage",
                context,
                imageContent.HtmlImage,
                position.X,
                position.Y,
                scale.X,
                scale.Y,
                referencePoint == ReferencePointType.Center);
        }

        private async Task InitJsModule()
        {
            await _jsModule.LoadingTask;
        }
    }
}
