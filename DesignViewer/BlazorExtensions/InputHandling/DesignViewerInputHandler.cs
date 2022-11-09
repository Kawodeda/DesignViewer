using BlazorExtensions.Commands;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorExtensions.InputHandling
{
    public class DesignViewerInputHandler : InputHandlerBase, IInputHandlingBuilder
    {
        private IDesignViewer _designViewer;

        public DesignViewerInputHandler(IDesignViewer designViewer)
        {
            _designViewer = designViewer;
        }

        public void UseHandler<T>() where T : InputHandlerBase
        {
            Next = (T?)Activator.CreateInstance(typeof(T), new object[] { _designViewer});
        }
    }
}
