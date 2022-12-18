using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface ILayerRenderer : IRenderer
    {
        Task Render(Layer surface);
    }
}
