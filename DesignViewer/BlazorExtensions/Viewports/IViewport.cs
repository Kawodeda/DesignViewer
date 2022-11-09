using Aurigma.Design.Math;

namespace BlazorExtensions.Viewports
{
    public interface IViewport : IScrollbar, IZoomable
    {
        public Size Size { get; set; }
    }
}
