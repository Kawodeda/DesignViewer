
namespace Aurigma.Design.Math
{
    public partial class Sides
    {
        public Sides(float left, float top, float right, float bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Sides(float horizontal, float vertical)
            : this(horizontal, vertical, horizontal, vertical) {}

        public Sides(float sides)
            : this(sides, sides, sides, sides) { }
    }
}
