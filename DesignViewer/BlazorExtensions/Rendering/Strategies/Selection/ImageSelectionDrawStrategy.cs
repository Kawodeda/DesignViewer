using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Models;
using BlazorExtensions.Services;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies.Selection
{
    public class ImageSelectionDrawStrategy : BaseElementDrawStrategy
    {
        private readonly IImageContentService _imageContentService;
        private readonly Affine2DMatrix _basisTransform;

        public ImageSelectionDrawStrategy(Element element, Affine2DMatrix basis, IImageContentService imageContentService) 
            : base(element)
        {
            _imageContentService = imageContentService;
            _basisTransform = basis;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            Image image = _element.Content.Image;
            ImageContent? imageContent = _imageContentService.GetImageContent(image.StorageId);

            if (imageContent == null)
            {
                return;
            }

            Point topLeftPos = _element.Position;
            topLeftPos = topLeftPos.Scale(_basisTransform.ScaleFactor.X, _basisTransform.ScaleFactor.Y);
            Point scale = _element.Transform.ScaleFactor;
            float width = imageContent.Size.Width * scale.X * _basisTransform.ScaleFactor.X;
            float height = imageContent.Size.Height * scale.Y * _basisTransform.ScaleFactor.Y;

            if (_element.ReferencePoint == ReferencePointType.Center)
            {
                topLeftPos -= new Point(width, height) * 0.5f;
            }

            await context.SetStrokeStyleAsync("yellow");
            await context.SetLineDashAsync(new[] { 6f, 5f });
            await context.SetLineWidthAsync(2);
            await context.StrokeRectAsync(topLeftPos.X, topLeftPos.Y, width, height);
        }
    }
}
