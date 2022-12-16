using BlazorExtensions.Services.Exceptions;
using Microsoft.JSInterop;

namespace BlazorExtensions.Services.JsInterop
{
    public class JsModulesProvider : IJsModulesProvider
    {
        private readonly IJSRuntime _jsRuntime;

        private JsModule _renderingModule = default!;
        private JsModule _imageContentServiceModule = default!;
        private JsModule _designViewerModule = default!;
        private JsModule _assetManagerModule = default!;

        private const string Import = "import";
        private const string ModulePrefix = "./_content/BlazorExtensions/";

        public JsModulesProvider(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            Initialize();
        }

        JsModule IJsModulesProvider.Rendering => _renderingModule;

        JsModule IJsModulesProvider.ImageContentService => _imageContentServiceModule;

        JsModule IJsModulesProvider.DesignViewer => _designViewerModule;

        JsModule IJsModulesProvider.AssetManager => _assetManagerModule;

        private void Initialize()
        {
            var getRendering = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}/Scripts/Rendering.js")
                .AsTask()
                .ContinueWith(FailureFilter);
            _renderingModule = new JsModule(getRendering);

            var getImageContentService = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}/Scripts/ImageContentService.js")
                .AsTask()
                .ContinueWith(FailureFilter);
            _imageContentServiceModule = new JsModule(getImageContentService);

            var getDesignViewer = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}DesignViewer.razor.js")
                .AsTask()
                .ContinueWith(FailureFilter);
            _designViewerModule = new JsModule(getDesignViewer);

            var getAssetManager = _jsRuntime.InvokeAsync<IJSObjectReference>(Import, $"{ModulePrefix}/Scripts/AssetManager.js")
                .AsTask()
                .ContinueWith(FailureFilter);
            _assetManagerModule = new JsModule(getAssetManager);
        }

        private IJSObjectReference FailureFilter(Task<IJSObjectReference> moduleTask)
        {
            if (moduleTask.Result == null)
            {
                throw new JsModuleLoadingException();
            }

            return moduleTask.Result;
        }
    }
}
