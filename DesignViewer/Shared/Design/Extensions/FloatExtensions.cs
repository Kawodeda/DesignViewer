namespace Aurigma.Design.Math
{
    public static class FloatExtensions
    {
        public static bool NearlyEqual(float a, float b, float epsilon)
        {
            float diff = MathF.Abs(a - b);

            return diff < epsilon;
        }

        public static bool NearlyEquals(this float a, float b, float epsilon)
        {
            return NearlyEqual(a, b, epsilon);
        }
    }
}
