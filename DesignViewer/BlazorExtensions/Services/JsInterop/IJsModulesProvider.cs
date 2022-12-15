using BlazorExtensions.Models;

namespace BlazorExtensions.Services.JsInterop
{
    public interface IJsModulesProvider
    {
        internal JsModule Rendering { get; }

        internal JsModule ImageContentService { get; }

        internal JsModule DesignViewer { get; }

        internal JsModule AssetManager { get; }
    }
}
