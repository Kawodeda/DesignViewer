using BlazorExtensions.Rendering.Strategies;
using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface ISelectionDrawStrategyFactory
    {
        IDrawStrategy Create(Element element);
    }
}
