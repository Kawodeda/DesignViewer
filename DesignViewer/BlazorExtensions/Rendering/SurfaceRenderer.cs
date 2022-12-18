using Blazor.Extensions.Canvas.Canvas2D;
using BlazorExtensions.Extensions;
using BlazorExtensions.Rendering.Exceptions;
using Model.Design;
using Model.Design.Appearance.Color;
using Model.Design.Content;
using Model.Design.Math;
using Model.Utils;

namespace BlazorExtensions.Rendering
{
    public class SurfaceRenderer : BaseRenderer, ISurfaceRenderer
    {
        private readonly ILayerRenderer _layerRenderer;
        private readonly IImageRenderer _imageRenderer;
        private readonly ISelectionDrawStrategyFactory _selectionDrawStrategyFactory;

        public SurfaceRenderer(
            ILayerRenderer layerRenderer, 
            IImageRenderer imageRenderer,
            ISelectionDrawStrategyFactory selectionDrawStrategyFactory)
        {
            _layerRenderer = layerRenderer;
            _selectionDrawStrategyFactory = selectionDrawStrategyFactory;
            _imageRenderer = imageRenderer;
        }

        public override Canvas2DContext? Context 
        {
            get
            {
                return _context;
            } 
            set
            {
                _context = value;
                _layerRenderer.Context = value;
            }
        }

        public async Task Render(Surface surface, float width, float height, Affine2DMatrix transform)
        {
            if (_context == null)
            {
                throw new ContextNotSetException(ContextNotSetMessage);
            }

            await _context.SaveAsync();

            await _context.SetTransformAsync(1, 0, 0, 1, 0, 0);
            await _context.ClearRectAsync(0, 0, width, width);

            await _context.SetTransformAsync(transform);

            if (surface.Mockup != null)
            {
                await RenderMockup(surface.Mockup);
            }

            await RenderLayers(surface.Layers);
            await RenderArtboards(surface.Artboards, transform);

            await _context.RestoreAsync();
        }

        public async Task RenderSelection(Element element, Affine2DMatrix transform)
        {
            if (_context == null)
            {
                throw new ContextNotSetException(ContextNotSetMessage);
            }

            Affine2DMatrix elementTransform = element.Transform.RotationMatrix;

            await _context.SaveAsync();

            await _context.TransformAsync(transform * elementTransform);
            await _selectionDrawStrategyFactory.Create(element).Draw(_context);

            await _context.RestoreAsync();
        }

        private async Task RenderArtboards(IEnumerable<Artboard> artboards, Affine2DMatrix transform)
        {
            foreach(Artboard artboard in artboards)
            {
                await RenderArtboard(artboard, transform);
            }
        }

        private async Task RenderArtboard(Artboard artboard, Affine2DMatrix transform)
        {
            await _context!.SaveAsync();

            Affine2DMatrix basis = artboard.Basis;
            await _context!.TransformAsync(basis);

            Size size = artboard.Size;

            ProcessColor fillColor = artboard.Background.Solid.Color.Process;
            await _context!.SetFillStyleAsync(ColorConverter.ToHtml(fillColor.Rgb, fillColor.Alpha));
            await _context!.FillRectAsync(0, 0, size.Width, size.Height);

            await _context!.SetTransformAsync(transform.RotationMatrix * transform.TranslationMatrix);
            await _context!.SetStrokeStyleAsync("rgba(0, 100, 255, 1)");
            await _context!.SetLineDashAsync(new float[] { 10, 5 });
            await _context!.StrokeRectAsync(0, 0, size.Width * transform.ScaleFactor.X, size.Height * transform.ScaleFactor.Y);

            await _context!.RestoreAsync();
        }

        private async Task RenderLayers(IEnumerable<Layer> layers)
        {
            foreach (Layer layer in layers)
            {
                await _layerRenderer.Render(layer);
            }
        }

        private async Task RenderMockup(Mockup mockup)
        {
            await _context!.SaveAsync();

            await _context!.TransformAsync(mockup.Transform.RotationMatrix);
            await _imageRenderer.Render(_context, mockup.Content, mockup.Position, mockup.Transform.ScaleFactor, ReferencePointType.Center);

            await _context!.RestoreAsync();
        }
    }
}
