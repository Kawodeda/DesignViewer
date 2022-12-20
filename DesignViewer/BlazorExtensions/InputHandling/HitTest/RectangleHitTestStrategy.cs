using Model.Design;
using Model.Design.Content.Controls;
using Model.Design.Math;
using System.Xml.Linq;

namespace BlazorExtensions.InputHandling.HitTest
{
    public class RectangleHitTestStrategy : BaseHitTestStrategy
    {
        public RectangleHitTestStrategy(Element element) : base(element) { }

        public override bool HitTest(Point point, Affine2DMatrix transform)
        {
            RectangleControls rectangle
                = _element.Content.ClosedVector.Controls.Rectangle;
            Point elementPos = _element.Position;
            Point scale = _element.Transform.ScaleFactor;
            Point corner1 = elementPos + new Point(rectangle.Corner1.X * scale.X, rectangle.Corner1.Y * scale.Y);
            Point corner2 = elementPos + new Point(rectangle.Corner2.X * scale.X, rectangle.Corner2.Y * scale.Y);
            point *= _element.Transform.RotationMatrix * transform.Inverse();

            return point.X > corner1.X
                && point.X < corner2.X
                && point.Y > corner1.Y
                && point.Y < corner2.Y;
        }
    }
}
