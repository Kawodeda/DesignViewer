using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Appearance.Color;
using Model.Design.Content.Controls;
using Model.Design.Math;
using Model.Utils;

namespace BlazorExtensions.Rendering.Strategies
{
    public class RectangleDrawStrategy : BaseElementDrawStrategy
    {
        public RectangleDrawStrategy(Element element) : base(element) { }

        public override async Task Draw(Canvas2DContext context)
        {
            RectangleControls rectangle = _element.Content.ClosedVector.Controls.Rectangle;
            ProcessColor fillColor = _element.Content.ClosedVector.Fill.Solid.Color.Process;
            var scale = _element.Transform.ScaleFactor;
            Point topLeftPos = _element.Position + new Point(rectangle.Corner1.X * scale.X, rectangle.Corner1.Y * scale.Y);
            float width = rectangle.Width * scale.X;
            float height = rectangle.Height * scale.Y;
            RgbColor rgb = fillColor.Rgb;
            uint alpha = fillColor.Alpha;

            await context.SetFillStyleAsync(ColorConverter.ToHtml(rgb, alpha));
            await context.FillRectAsync(topLeftPos.X, topLeftPos.Y, width, height);
        }
    }
}
