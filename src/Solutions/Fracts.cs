// https://www.codewars.com/kata/common-denominators/train/csharp

using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class Fracts
    {
        public static string ConvertFrac(long[,] lst)
        {
            var len = lst.GetLength(0);
            if (len == 0)
            {
                return string.Empty;
            }
            if (len == 1)
            {
                return $"({lst[0, 0]},{lst[0, 1]})";
            }

            var stack = new Stack<long>(len);
            for (var i = 0; i < len; i++)
            {
                stack.Push(lst[i, 1]);
            }

            var a = stack.Pop();
            var b = stack.Pop();
            var denominator = Lcm(a, b);
            while (stack.Count != 0)
            {
                denominator = Lcm(denominator, stack.Pop());
            }

            var sb = new StringBuilder();
            for (var i = 0; i < len; i++)
            {
                var times = denominator / lst[i, 1];
                sb.Append($"({times * lst[i, 0]},{denominator})");
            }

            return sb.ToString();
        }

        private static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
        }

        private static long Gcd(long a, long b)
        {
            return a % b == 0 ? b : Gcd(b, a % b);
        }
    }
}