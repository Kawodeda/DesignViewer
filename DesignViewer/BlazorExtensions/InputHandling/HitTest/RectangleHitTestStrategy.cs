using Model.Design;
using Model.Design.Content.Controls;
using Model.Design.Math;

namespace BlazorExtensions.InputHandling.HitTest
{
    public class RectangleHitTestStrategy : BaseHitTestStrategy
    {
        public RectangleHitTestStrategy(Element element) : base(element) { }

        public override bool HitTest(Point point, Affine2DMatrix transform)
        {
            RectangleControls rectangle = _element.Content.ClosedVector.Controls.Rectangle;
            Point topLeftPos = _element.Position;

            Point scale = _element.Transform.ScaleFactor;
            Point corner1 = topLeftPos + new Point(rectangle.Corner1.X * scale.X, rectangle.Corner1.Y * scale.Y);
            Point corner2 = topLeftPos + new Point(rectangle.Corner2.X * scale.X, rectangle.Corner2.Y * scale.Y);
            point *= _element.Transform.RotationMatrix * transform.Inverse();

            return point.X > corner1.X
                && point.X < corner2.X
                && point.Y > corner1.Y
                && point.Y < corner2.Y;
        }
    }
}
