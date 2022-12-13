using BlazorExtensions.Rendering.Strategies;
using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface IDrawStrategyFactory
    {
        IDrawStrategy Create(Element element);
    }
}
