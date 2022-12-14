using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Rendering.Exceptions;
using Model.Design;
using Model.Design.Content;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public class DesignRenderer : IDesignRenderer
    {
        private const string ContextNotSetMessage = "Rendering context was not set";

        private IElementDrawStrategyFactory _factory;
        private Canvas2DContext? _context;

        public DesignRenderer(IElementDrawStrategyFactory factory)
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
                    Affine2DMatrix transform = element.Transform.RotationMatrix;

                    await _context.SaveAsync();
                    await _context.TransformAsync(
                        transform.M11,
                        transform.M12,
                        transform.M21,
                        transform.M22,
                        transform.D1,
                        transform.D2);
                    await _factory.Create(element).Draw(_context);
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

            Affine2DMatrix transform = element.Transform.RotationMatrix;

            await _context.SaveAsync();
            await _context.TransformAsync(
                transform.M11,
                transform.M12,
                transform.M21,
                transform.M22,
                transform.D1,
                transform.D2);
            await _factory.CreateSelection(element).Draw(_context);
            await _context.RestoreAsync();
        }
    }
}
