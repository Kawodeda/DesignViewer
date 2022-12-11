namespace Model.Design.Content.Controls
{
    public sealed partial class RectangleControls
    {
        public float Width
        {
            get
            {
                return Corner2.X - Corner1.X;
            }
        }

        public float Height
        {
            get
            {
                return Corner2.Y - Corner1.Y;
            }
        }
    }
}
