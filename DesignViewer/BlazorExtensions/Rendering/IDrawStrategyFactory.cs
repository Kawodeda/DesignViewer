using BlazorExtensions.Rendering.Strategies;
using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface IDrawStrategyFactory
    {
        Task<IElementDrawStrategy> Create(Element element);
    }
}
