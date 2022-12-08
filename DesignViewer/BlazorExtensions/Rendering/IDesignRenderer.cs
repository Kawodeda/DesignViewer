using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface IDesignRenderer
    {
        public Task Render(Surface surface);

        public Task RenderSelection(Element element);
    }
}
