using Microsoft.JSInterop;

namespace BlazorExtensions.Models
{
    internal class JsModule
    {
        internal JsModule(Task<IJSObjectReference> loadingTask)
        {
            LoadingTask = loadingTask.ContinueWith(module =>
            {
                Module = module.Result;

                return Module;
            });
        }

        internal IJSObjectReference? Module { get; private set; }

        internal Task<IJSObjectReference> LoadingTask { get; }
    }
}
