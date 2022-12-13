using ApiClient;
using BlazorExtensions.Rendering;
using DesignViewer.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IDesignsApiClient>(sp => new DesignsApiClient(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<IAssetsApiClient>(sp => new AssetsApiClient(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<IDrawStrategyFactory, DrawStrategyFactory>();

builder.Services.AddTransient<IDesignRenderer, DesignRenderer>();

await builder.Build().RunAsync();
