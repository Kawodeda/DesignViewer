using Microsoft.JSInterop;

namespace BlazorExtensions.Services
{
    public interface IJsModulesProvider
    {
        internal bool IsInitialized { get; }

        internal event EventHandler Initialized;

        internal IJSObjectReference? Rendering { get; }

        internal IJSObjectReference? ImageContentService { get; }

        internal IJSObjectReference? DesignViewer { get; }
    }
}
