using BlazorExtensions.Rendering.Strategies;
using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.Rendering
{
    public interface ISelectionDrawStrategyFactory
    {
        IDrawStrategy Create(Element element, Affine2DMatrix basis);
    }
}
