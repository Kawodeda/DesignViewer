using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Rendering.Exceptions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.Extensions.DependencyInjection;
using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public class DesignRenderer : IDesignRenderer
    {
        private const string ContextNotSetMessage = "Rendering context was not set";

        private IDrawStrategyFactory _factory;
        private Canvas2DContext? _context;

        public DesignRenderer(IDrawStrategyFactory factory)
        {
            _factory = factory;
        }

        public Canvas2DContext? Context
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
            }
        }

        public async Task Render(Surface surface)
        {
            if (_context == null)
            {
                throw new ContextNotSetException(ContextNotSetMessage);
            }

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
                    await (await _factory.Create(element)).Draw(_context);
                    await _context.RestoreAsync();
                }
            }
        }

        public async Task RenderSelection(Element element)
        {
            if (_context == null)
            {
                throw new ContextNotSetException(ContextNotSetMessage);
            }

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
