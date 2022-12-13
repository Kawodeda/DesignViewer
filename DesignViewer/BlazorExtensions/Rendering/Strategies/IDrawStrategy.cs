using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorExtensions.Rendering.Strategies
{
    public interface IDrawStrategy
    {
        public Task Draw(Canvas2DContext context);
    }
}
