using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies
{
    public class ImageDrawStrategy : BaseElementDrawStrategy
    {
        private readonly IImageRenderer _imageRenderer;

        public ImageDrawStrategy(Element element, IImageRenderer imageRenderer) 
            : base(element)
        {
            _imageRenderer = imageRenderer;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            Image image = _element.Content.Image;
            Point scale = _element.Transform.ScaleFactor;

            await _imageRenderer.Render(context, image, _element.Position, scale, _element.ReferencePoint);
        }
    }
}
