// https://www.codewars.com/kata/password-system/train/csharp

using System;

namespace Solutions
{
    public static class Crisis
    {
        public static string HelpZoom(int[] key)
        {
            if (key == null || key.Length == 0) throw new ArgumentNullException(nameof(key));
            int l = 0, r = key.Length - 1;
            while (l <= r)
            {
                if (key[l] != key[r])
                    return "No";
                l++;
                r--;
            }

            return "Yes";
        }
    }
}