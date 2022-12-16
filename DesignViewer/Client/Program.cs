using ApiClient;
using BlazorExtensions.InputHandling.HitTest;
using BlazorExtensions.Rendering;
using BlazorExtensions.Services;
using BlazorExtensions.Services.JsInterop;
using DesignViewer.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IDesignsApiClient>(sp => new DesignsApiClient(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<IAssetsApiClient>(sp => new AssetsApiClient(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<IElementDrawStrategyFactory, ElementDrawStrategyFactory>();
builder.Services.AddScoped<ISelectionDrawStrategyFactory, SelectionDrawStrategyFactory>();
builder.Services.AddScoped<IHitTestStrategyFactory, HitTestStrategyFactory>();
builder.Services.AddScoped<IElementFactory, ElementFactory>();
builder.Services.AddScoped<IJsModulesProvider, JsModulesProvider>();
builder.Services.AddScoped<IAssetService, AssetService>();
builder.Services.AddScoped<IImageContentService, ImageContentService>();

builder.Services.AddTransient<ISurfaceRenderer, SurfaceRenderer>();
builder.Services.AddTransient<ILayerRenderer, LayerRenderer>();

await builder.Build().RunAsync();
