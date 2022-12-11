using BlazorViewer.Server.Services;
using BlazorViewer.Server.Options;
using Microsoft.AspNetCore.ResponseCompression;
using DesignViewer.Server.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DesignsStorageOptions>(
    builder.Configuration.GetSection(DesignsStorageOptions.DesignsStorage));
builder.Services.Configure<AssetsStorageOptions>(
    builder.Configuration.GetSection(AssetsStorageOptions.AssetsStorage));

builder.Services.AddScoped<IDesignStorageService, DesignFileStorageService>();
builder.Services.AddSingleton<INameGeneratorService, FileNameGeneratorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
