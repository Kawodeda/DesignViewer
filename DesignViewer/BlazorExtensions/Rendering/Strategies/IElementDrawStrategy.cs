using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;

namespace BlazorExtensions.Rendering.Strategies
{
    public interface IElementDrawStrategy
    {
        public Task Draw(Canvas2DContext context);
    }
}
