using Model.Design.Math;

namespace BlazorExtensions.InputHandling.HitTest
{
    public interface IHitTestStrategy
    {
        bool HitTest(Point point, Affine2DMatrix transform);
    }
}
