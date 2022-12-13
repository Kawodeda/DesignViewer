using Blazor.Extensions.Canvas.Canvas2D;
using Model.Design;

namespace BlazorExtensions.Rendering.Strategies
{
    public abstract class BaseElementDrawStrategy : IDrawStrategy
    {
        protected Element _element;

        protected BaseElementDrawStrategy(Element element)
        {
            _element = element;
        }

        public abstract Task Draw(Canvas2DContext context);
    }
}
