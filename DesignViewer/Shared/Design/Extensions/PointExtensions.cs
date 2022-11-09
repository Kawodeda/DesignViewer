namespace Aurigma.Design.Math
{
    public sealed partial class Point
    {
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Point Negate(Point point)
        {
            return new Point(-point.X, -point.Y);
        }

        public static Point Multiply(Affine2DMatrix matrix, Point point)
        {
            float x = point.X * matrix.M11 + point.Y * matrix.M12 + matrix.D1;
            float y = point.X * matrix.M21 + point.Y * matrix.M22 + matrix.D2;

            return new Point(x, y);
        }

        public static Point Multiply(Point point, Affine2DMatrix matrix)
        {
            return Multiply(matrix, point);
        }

        public static Point operator -(Point point)
        {
            return Negate(point);
        }

        public static Point operator *(Point point, Affine2DMatrix matrix)
        {
            return Multiply(point, matrix);
        }

        public static Point operator *(Affine2DMatrix matrix, Point point)
        {
            return Multiply(matrix, point);
        }

        public static Point operator +(Point a, Point b)
        {
            return a.Translate(b);
        }

        public Point MultiplyBy(Affine2DMatrix matrix)
        {
            return Multiply(this, matrix);
        }

        public Point Translate(Point shift)
        {
            return MultiplyBy(Affine2DMatrix.CreateTranslate(shift));
        }

        public Point Scale(float factor)
        {
            return Scale(factor, factor);
        }

        public Point Scale(float dx, float dy)
        {
            return MultiplyBy(Affine2DMatrix.CreateScale(dx, dy));
        }

        public Point ScaleAt(float factor, Point center)
        {
            return ScaleAt(factor, factor, center);
        }

        public Point ScaleAt(float dx, float dy, Point center)
        {
            return MultiplyBy(Affine2DMatrix.CreateIdentity().ScaleAt(dx, dy, center));
        }

        public Point Rotate(float angle)
        {
            return MultiplyBy(Affine2DMatrix.CreateRotate(angle));
        }

        public Point RotateAt(float angle, Point center)
        {
            return MultiplyBy(Affine2DMatrix.CreateIdentity().RotateAt(angle, center));
        }

        public bool NearlyEquals(Point other, float epsilon)
        {
            if (epsilon < 0.0f)
            {
                throw new ArgumentException("Received negative epsilon");
            }

            return X.NearlyEquals(other.X, epsilon) 
                && Y.NearlyEquals(other.Y, epsilon);
        }
    }
}
