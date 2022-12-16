using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorExtensions.Rendering
{
    public interface IRenderer
    {
        Canvas2DContext? Context { get; set; }
    }
}
