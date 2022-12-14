using BlazorExtensions.Rendering.Strategies;
using Model.Design;

namespace BlazorExtensions.Rendering
{
    public interface IElementDrawStrategyFactory
    {
        IDrawStrategy Create(Element element);

        IDrawStrategy CreateSelection(Element element);
    }
}
