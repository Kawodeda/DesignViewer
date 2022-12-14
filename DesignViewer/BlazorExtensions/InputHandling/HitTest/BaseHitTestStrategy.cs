using Model.Design;
using Model.Design.Math;

namespace BlazorExtensions.InputHandling.HitTest
{
    public abstract class BaseHitTestStrategy : IHitTestStrategy
    {
        protected readonly Element _element;

        public BaseHitTestStrategy(Element element)
        {
            _element = element;
        }

        public abstract bool HitTest(Point point, Affine2DMatrix transform);
    }
}
