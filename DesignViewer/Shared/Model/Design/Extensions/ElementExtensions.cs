using Model.Design.Content.Controls;
using Model.Design.Math;

namespace Model.Design
{
    public sealed partial class Element
    {
        /// <summary>
        /// Returns coordinates of the center of the element relative to its Position 
        /// </summary>
        public Point Center
        {
            get
            {
                switch (ReferencePoint)
                {
                    case ReferencePointType.TopLeftCorner:
                        RectangleControls rectangle = Content.ClosedVector.Controls.Rectangle;
                        Point center = rectangle.Corner1 + (new Point(rectangle.Width, rectangle.Height) * 0.5f);

                        return center;

                    default:
                        return new Point(0, 0);
                }
            }
        }
    }
}
