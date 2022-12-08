using Model.Design.Appearance.Color;

namespace BlazorExtensions.Rendering
{
    public class WebColorConverter
    {
        public static string ToWebColor(RgbColor rgb, uint alpha = 255)
        {
            if (alpha == 255)
            {
                return $"rgb({rgb.R},{rgb.G},{rgb.B})";
            }

            return $"rgba({rgb.R},{rgb.G},{rgb.B},{alpha / 255})";
        }
    }
}
