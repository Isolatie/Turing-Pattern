using System;

namespace TuringPatternLibrary
{
    public static class ColorScaleChange
    {

        // Source: https://stackoverflow.com/questions/4793729/rgb-to-hsl-and-back-calculation-problems
        public static (int R, int G, int B) ColorFromHSL(float hue, float saturation, float lightness)
        {
            // Normalize hue
            double h = hue / 360.0;

            // Calculate the max and min lightness values based on saturation
            double max = lightness < 0.5 ? lightness * (1 + saturation) : (lightness + saturation) - (lightness * saturation);
            double min = (lightness * 2) - max;

            // Calculate the RGB channels
            int r = (int)(255 * RGBChannelFromHue(min, max, h + 1.0 / 3.0));
            int g = (int)(255 * RGBChannelFromHue(min, max, h));
            int b = (int)(255 * RGBChannelFromHue(min, max, h - 1.0 / 3.0));

            return (r, g, b);  // Return RGB values
        }

        private static double RGBChannelFromHue(double min, double max, double h)
        {
            if (h < 0) h += 1.0;
            if (h * 6 < 1) return min + (max - min) * 6 * h;
            if (h * 2 < 1) return max;
            if (h * 3 < 2) return min + (max - min) * 6 * (2.0 / 3.0 - h);

            return min;
        }
    }
}
