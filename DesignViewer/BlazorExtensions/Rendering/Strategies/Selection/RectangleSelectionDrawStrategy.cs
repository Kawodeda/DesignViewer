using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies.Selection
{
    public class RectangleSelectionDrawStrategy : BaseElementDrawStrategy
    {
        private readonly Affine2DMatrix _basisTransform;

        public RectangleSelectionDrawStrategy(Element element, Affine2DMatrix basisTransform) 
            : base(element)
        {
            _basisTransform = basisTransform;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            RectangleControls rectangle = _element.Content.ClosedVector.Controls.Rectangle;

            Point scale = _element.Transform.ScaleFactor;
            Point topLeftPos = _element.Position + new Point(rectangle.Corner1.X * scale.X, rectangle.Corner1.Y * scale.Y);
            topLeftPos = topLeftPos.Scale(_basisTransform.ScaleFactor.X, _basisTransform.ScaleFactor.Y);
            float width = rectangle.Width * scale.X * _basisTransform.ScaleFactor.X;
            float height = rectangle.Height * scale.Y * _basisTransform.ScaleFactor.Y;

            await context.SetStrokeStyleAsync("yellow");
            await context.SetLineDashAsync(new[] { 6f, 5f });
            await context.SetLineWidthAsync(2);
            await context.StrokeRectAsync(topLeftPos.X, topLeftPos.Y, width, height);
        }
    }
}
