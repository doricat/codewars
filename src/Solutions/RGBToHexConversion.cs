// https://www.codewars.com/kata/rgb-to-hex-conversion/train/csharp

namespace Solutions
{
    public class RgbToHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            r = r >= 0 ? r : 0;
            g = g >= 0 ? g : 0;
            b = b >= 0 ? b : 0;

            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;

            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}