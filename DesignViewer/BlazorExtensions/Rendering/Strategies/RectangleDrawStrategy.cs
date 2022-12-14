using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Appearance.Color;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.Rendering.Strategies
{
    public class RectangleDrawStrategy : BaseElementDrawStrategy
    {
        public RectangleDrawStrategy(Element element) : base(element) { }

        public override async Task Draw(Canvas2DContext context)
        {
            RectangleControls rectangle = _element.Content.ClosedVector.Controls.Rectangle;
            ProcessColor fillColor = _element.Content.ClosedVector.Fill.Solid.Color.Process;
            Point position = _element.Position.Clone();
            float x = position.X + rectangle.Corner1.X;
            float y = position.Y + rectangle.Corner1.Y;
            var scale = _element.Transform.ScaleFactor;
            float width = rectangle.Width * scale.X;
            float height = rectangle.Height * scale.Y;
            RgbColor rgb = fillColor.Rgb;
            uint alpha = fillColor.Alpha;

            await context.SetFillStyleAsync(ColorConverter.ToHtml(rgb, alpha));
            await context.FillRectAsync(x, y, width, height);
        }
    }
}
