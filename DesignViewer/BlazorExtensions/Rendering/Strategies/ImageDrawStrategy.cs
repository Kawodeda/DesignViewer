using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Services;
using Microsoft.JSInterop;
using Model.Design;
using Model.Design.Content;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies
{
    public class ImageDrawStrategy : BaseElementDrawStrategy
    {
        private readonly IImageContentService _imageContentService;
        private readonly IJsModulesProvider _jsModulesProvider;

        private IJSObjectReference? _jsModule;

        public ImageDrawStrategy(
            Element element, 
            IImageContentService imageContentService,
            IJsModulesProvider jsModulesProvider) 
            : base(element)
        {
            _imageContentService = imageContentService;
            _jsModulesProvider = jsModulesProvider;
            InitJsModule();
        }

        public override async Task Draw(Canvas2DContext context)
        {
            if (_jsModule == null)
            {
                return;
            }

            Image image = _element.Content.Image;
            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);
            if (imageContent == null)
            {
                return;
            
            }

            Point scale = _element.Transform.ScaleFactor;

            await _jsModule.InvokeVoidAsync("drawImage", context, 
                imageContent.HtmlImage, _element.Position.X, _element.Position.Y, 
                scale.X, scale.Y);
        }

        public void InitJsModule()
        {
            if (_jsModulesProvider.IsInitialized)
            {
                _jsModule = _jsModulesProvider.Rendering;
                return;
            }

            _jsModulesProvider.Initialized += (sender, args) => 
                _jsModule = _jsModulesProvider.Rendering;
        }
    }
}
