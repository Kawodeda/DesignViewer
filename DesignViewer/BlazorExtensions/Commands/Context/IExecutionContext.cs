using BlazorExtensions.Viewports;

namespace BlazorExtensions.Commands.Context
{
    public interface IExecutionContext
    {
        public IDesignViewer DesignViewer { get; }

        public IViewport Viewport { get; }
    }
}
