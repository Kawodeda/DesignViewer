using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies.Selection
{
    public class RectangleSelectionDrawStrategy : BaseElementDrawStrategy
    {
        public RectangleSelectionDrawStrategy(Element element) : base(element) { }

        public override async Task Draw(Canvas2DContext context)
        {
            RectangleControls rectangle = _element.Content.ClosedVector.Controls.Rectangle;

            Point scale = _element.Transform.ScaleFactor;
            Point topLeftPos = _element.Position + new Point(rectangle.Corner1.X * scale.X, rectangle.Corner1.Y * scale.Y);
            float width = rectangle.Width * scale.X;
            float height = rectangle.Height * scale.Y;
            float lineWidth = 1;

            await context.SetStrokeStyleAsync("yellow");
            await context.SetLineWidthAsync(lineWidth);
            await context.StrokeRectAsync(topLeftPos.X, topLeftPos.Y, width, height);
        }
    }
}
