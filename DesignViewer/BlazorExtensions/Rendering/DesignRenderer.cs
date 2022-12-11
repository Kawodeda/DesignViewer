using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public class DesignRenderer : IDesignRenderer
    {
        private readonly Canvas2DContext _context;

        public DesignRenderer(Canvas2DContext context)
        {
            _context = context;
        }

        public async Task Render(Surface surface)
        {
            foreach (var layer in surface.Layers)
            {
                foreach (Element element in layer.Elements)
                {
                    Affine2DMatrix transform = element.Transform;

                    await _context.SaveAsync();
                    await _context.TransformAsync(
                        transform.M11,
                        transform.M12,
                        transform.M21,
                        transform.M22,
                        transform.D1,
                        transform.D2);
                    await DrawStrategyFactory.Create(element).Draw(_context);
                    await _context.RestoreAsync();
                }
            }
        }

        public async Task RenderSelection(Element element)
        {
            await _context.SaveAsync();
            Affine2DMatrix transform = element.Transform;

            await _context.TransformAsync(
                transform.M11,
                transform.M12,
                transform.M21,
                transform.M22,
                transform.D1,
                transform.D2);

            float x = element.Position.X + element.Content.ClosedVector.Controls.Rectangle.Corner1.X;
            float y = element.Position.Y + element.Content.ClosedVector.Controls.Rectangle.Corner1.Y;
            float width = element.Content.ClosedVector.Controls.Rectangle.Corner2.X - element.Content.ClosedVector.Controls.Rectangle.Corner1.X;
            float height = element.Content.ClosedVector.Controls.Rectangle.Corner2.Y - element.Content.ClosedVector.Controls.Rectangle.Corner1.Y;

            float lineWidth = 1;

            await _context.SetStrokeStyleAsync("yellow");
            await _context.SetLineWidthAsync(lineWidth);
            await _context.StrokeRectAsync(x, y, width, height);

            await _context.RestoreAsync();
        }
    }
}
