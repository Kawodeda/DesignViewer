using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface IDesignRenderer
    {
        public Canvas2DContext? Context { get; set; }

        public Task Render(Surface surface);

        public Task RenderSelection(Element element);
    }
}
