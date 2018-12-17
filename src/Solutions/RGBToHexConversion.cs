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

            var br = (byte) (r > 255 ? 255 : r);
            var bg = (byte) (g > 255 ? 255 : g);
            var bb = (byte) (b > 255 ? 255 : b);

            return (br <= 15 ? $"0{br:X}" : $"{br:X}") + (bg <= 15 ? $"0{bg:X}" : $"{bg:X}") + (bb <= 15 ? $"0{bb:X}" : $"{bb:X}");
        }
    }
}