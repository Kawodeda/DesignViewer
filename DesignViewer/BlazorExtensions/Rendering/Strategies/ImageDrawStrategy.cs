using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Services;
using BlazorExtensions.Services.JsInterop;
using Microsoft.JSInterop;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies
{
    public class ImageDrawStrategy : BaseElementDrawStrategy
    {
        private readonly IImageContentService _imageContentService;
        private readonly IJsModulesProvider _jsModulesProvider;
        private readonly JsModule _jsModule;

        public ImageDrawStrategy(
            Element element, 
            IImageContentService imageContentService,
            IJsModulesProvider jsModulesProvider) 
            : base(element)
        {
            _imageContentService = imageContentService;
            _jsModulesProvider = jsModulesProvider;
            _jsModule = _jsModulesProvider.Rendering;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            Image image = _element.Content.Image;
            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);
            if (imageContent == null)
            {
                return;
            
            }

            Point scale = _element.Transform.ScaleFactor;

            await InitJsModule();
            await _jsModule.Module!.InvokeVoidAsync(
                "drawImage", 
                context, 
                imageContent.HtmlImage, 
                _element.Position.X, 
                _element.Position.Y, 
                scale.X, 
                scale.Y);
        }

        private async Task InitJsModule()
        {
            await _jsModule.LoadingTask;
        }
    }
}
