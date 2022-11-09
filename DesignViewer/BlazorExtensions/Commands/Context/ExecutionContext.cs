using BlazorExtensions.Viewports;

namespace BlazorExtensions.Commands.Context
{
    public class ExecutionContext : IExecutionContext
    {
        public IDesignViewer DesignViewer { get; set; }

        public IViewport Viewport
        {
            get
            {
                return DesignViewer.Viewport;
            }
        }

        public ExecutionContext(IDesignViewer designViewer)
        {
            DesignViewer = designViewer;
        }
    }
}
