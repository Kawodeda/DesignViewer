using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Extensions;
using BlazorExtensions.Rendering.Exceptions;
using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public class LayerRenderer : BaseRenderer, ILayerRenderer
    {
        private IElementDrawStrategyFactory _factory;

        public LayerRenderer(IElementDrawStrategyFactory factory)
        {
            _factory = factory;
        }


        public async Task Render(Layer layer)
        {
            if (_context == null)
            {
                throw new ContextNotSetException(ContextNotSetMessage);
            }

            foreach (Element element in layer.Elements)
            {
                Affine2DMatrix transform = element.Transform.RotationMatrix;

                await _context.SaveAsync();

                await _context.TransformAsync(transform);
                await _factory.Create(element).Draw(_context);

                await _context.RestoreAsync();
            }
        }
    }
}
