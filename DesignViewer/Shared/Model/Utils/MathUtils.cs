namespace Model.Utils
{
    public class MathUtils
    {
        public static T Min<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) <= 0 ? a : b;
        }

        public static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }

        public static T Clamp<T>(T value, T min, T max) where T : IComparable
        {
            return Min(max, Max(min, value));
        }
    }
}
