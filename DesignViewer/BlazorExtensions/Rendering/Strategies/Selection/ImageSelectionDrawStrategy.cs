using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Services;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies.Selection
{
    public class ImageSelectionDrawStrategy : BaseElementDrawStrategy
    {
        private readonly IImageContentService _imageContentService;

        public ImageSelectionDrawStrategy(Element element, IImageContentService imageContentService) 
            : base(element)
        {
            _imageContentService = imageContentService;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            Image image = _element.Content.Image;
            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);

            if (imageContent == null)
            {
                return;
            }

            Point position = _element.Position;
            Point scale = _element.Transform.ScaleFactor;
            float width = imageContent.Size.Width * scale.X;
            float height = imageContent.Size.Height * scale.Y;
            float lineWidth = 1;

            await context.SetStrokeStyleAsync("yellow");
            await context.SetLineWidthAsync(lineWidth);
            await context.StrokeRectAsync(position.X, position.Y, width, height);
        }
    }
}
