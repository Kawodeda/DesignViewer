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
            Point corner1 = elementPos + rectangle.Corner1;
            Point corner2 = elementPos + rectangle.Corner2;
            point *= _element.Transform * transform.Inverse();

            return point.X > corner1.X
                && point.X < corner2.X
                && point.Y > corner1.Y
                && point.Y < corner2.Y;
        }
    }
}
