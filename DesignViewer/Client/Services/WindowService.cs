using Microsoft.JSInterop;
using Model.Design.Math;

namespace DesignViewer.Client.Services
{
    public class WindowService : IWindowService
    {
        private IJSRuntime _jsRuntime;
        private DotNetObjectReference<WindowService> _thisRef;

        public event EventHandler<Size>? Resized;

        public WindowService(IJSRuntime jsRuntime) 
        {
            _jsRuntime= jsRuntime;
            _thisRef = DotNetObjectReference.Create(this);
            InitAsync();
        }

        public async Task<Size> GetSizeAsync()
        {
            IJSObjectReference module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/WindowService.js");
            float width = await module.InvokeAsync<float>("getWindowWidth");
            float height = await module.InvokeAsync<float>("getWindowHeight");

            return new Size(width, height);
        }

        [JSInvokable]
        public void OnWindowResized(float width, float height)
        {
            Resized?.Invoke(this, new Size(width, height));
        }

        private async Task InitAsync()
        {
            IJSObjectReference module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/WindowService.js");
            await module.InvokeVoidAsync("addWindowResizedListener", _thisRef);
        }
    }
}
