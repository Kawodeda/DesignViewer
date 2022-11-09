using BlazorExtensions.Viewports;

namespace BlazorExtensions
{
    public interface IViewer
    {
        public IViewport Viewport { get; }
    }
}
