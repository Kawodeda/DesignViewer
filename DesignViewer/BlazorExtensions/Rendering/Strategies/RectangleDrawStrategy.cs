using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Appearance.Color;

namespace BlazorExtensions.Rendering.Strategies
{
    internal class RectangleDrawStrategy : BaseElementDrawStrategy
    {
        public RectangleDrawStrategy(Element element) : base(element)
        {

        }

        public override async Task Draw(Canvas2DContext context)
        {
            float x = _element.Position.X + _element.Content.ClosedVector.Controls.Rectangle.Corner1.X;
            float y = _element.Position.Y + _element.Content.ClosedVector.Controls.Rectangle.Corner1.Y;
            float width = _element.Content.ClosedVector.Controls.Rectangle.Corner2.X - _element.Content.ClosedVector.Controls.Rectangle.Corner1.X;
            float height = _element.Content.ClosedVector.Controls.Rectangle.Corner2.Y - _element.Content.ClosedVector.Controls.Rectangle.Corner1.Y;
            RgbColor color = _element.Content.ClosedVector.Fill.Solid.Color.Process.Rgb;
            uint alpha = _element.Content.ClosedVector.Fill.Solid.Color.Process.Alpha;

            await context.SetFillStyleAsync(ColorConverter.ToHtml(color, alpha));
            await context.FillRectAsync(x, y, width, height);
        }
    }
}
