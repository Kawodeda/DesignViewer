using Model.Design;

namespace BlazorExtensions.InputHandling.HitTest
{
    public interface IHitTestStrategyFactory
    {
        IHitTestStrategy Create(Element element);
    }
}
