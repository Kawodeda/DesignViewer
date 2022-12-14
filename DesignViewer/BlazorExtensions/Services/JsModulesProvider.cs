using Microsoft.JSInterop;

namespace BlazorExtensions.Services
{
    public class JsModulesProvider : IJsModulesProvider
    {
        private readonly IJSRuntime _jsRuntime;

        private bool _isInitialized = false;
        private event EventHandler? _initialized;
        private IJSObjectReference? _renderingModule;
        private IJSObjectReference? _imageContentServiceModule;
        private IJSObjectReference? _designViewerModule;

        private const string Import = "import";
        private const string ModulePrefix = "./_content/BlazorExtensions/";

        public JsModulesProvider(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            Initialize();
        }

        bool IJsModulesProvider.IsInitialized => _isInitialized;

        event EventHandler IJsModulesProvider.Initialized
        {
            add => _initialized += value;
            remove => _initialized -= value;
        }

        IJSObjectReference? IJsModulesProvider.Rendering => _renderingModule;

        IJSObjectReference? IJsModulesProvider.ImageContentService => _imageContentServiceModule;

        IJSObjectReference? IJsModulesProvider.DesignViewer => _designViewerModule;

        private void Initialize()
        {
            Task getRendering = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}/Scripts/Rendering.js")
                .AsTask()
                .ContinueWith(module => _renderingModule = module.Result);

            Task getImageContentService = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}/Scripts/ImageContentService.js")
                .AsTask()
                .ContinueWith(module => _imageContentServiceModule = module.Result);

            Task getDesignViewer = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}DesignViewer.razor.js")
                .AsTask()
                .ContinueWith(module => _designViewerModule = module.Result);

            Task.WhenAll(getRendering, getImageContentService, getDesignViewer)
                .ContinueWith((task) => 
                {
                    _isInitialized = true;
                    _initialized?.Invoke(this, new EventArgs());
                });
        }
    }
}
