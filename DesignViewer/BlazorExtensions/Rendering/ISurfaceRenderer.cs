using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public interface ISurfaceRenderer : IRenderer
    {
        Task Render(Surface surface, float width, float height, Affine2DMatrix transform);

        Task RenderSelection(Element element, Affine2DMatrix transform);
    }
}
