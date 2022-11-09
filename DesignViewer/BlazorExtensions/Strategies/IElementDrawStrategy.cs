using Blazor.Extensions.Canvas.Canvas2D;
using Aurigma.Design;

namespace BlazorExtensions.Strategies
{
    public interface IElementDrawStrategy
    {
        public Task Draw(Canvas2DContext context);
    }
}
