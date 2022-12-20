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
            float x = _element.Position.X + rectangle.Corner1.X;
            float y = _element.Position.Y + rectangle.Corner1.Y;
            Point scale = _element.Transform.ScaleFactor;
            float width = rectangle.Width * scale.X;
            float height = rectangle.Height * scale.Y;
            float lineWidth = 1;

            await context.SetStrokeStyleAsync("yellow");
            await context.SetLineWidthAsync(lineWidth);
            await context.StrokeRectAsync(x, y, width, height);
        }
    }
}
