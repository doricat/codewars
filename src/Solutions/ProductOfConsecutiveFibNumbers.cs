using System;

namespace Solutions
{
    public class ProductOfConsecutiveFibNumbers
    {
        public Tuple<ulong, ulong, bool> ProductFib(ulong m)
        {
            ulong n = 0;
            while (true)
            {
                var f1 = Fib(n);
                var f2 = Fib(n + 1);
                var prod = f1 * f2;
                if (prod == m)
                    return new Tuple<ulong, ulong, bool>(f1, f2, true);

                if (prod > m)
                    return new Tuple<ulong, ulong, bool>(f1, f2, false);

                n++;
            }
        }

        private static ulong Fib(ulong n)
        {
            var v = Math.Sqrt(5);
            return (ulong)Math.Round(Math.Pow((1 + v) / 2, n) / v);
        }
    }
}