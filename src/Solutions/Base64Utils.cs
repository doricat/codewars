// https://www.codewars.com/kata/base64-encoding/train/csharp

using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Solutions
{
    public static class Base64Utils
    {
        private const string IndexTable = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        public static string ToBase64(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (s == string.Empty) return string.Empty;

            var bytes = Encoding.UTF8.GetBytes(s);
            var bits = BuildBitArray(bytes);
            var sb = new StringBuilder(bits.Length / 6 + 2);

            for (int l = 0, r = 6; r <= bits.Length; r += 6)
            {
                var b = new byte();
                for (; l < r; l++)
                {
                    b = (byte) (b | Convert.ToByte(bits[l]));
                    if (l != r - 1)
                    {
                        b = (byte) (b << 1);
                    }
                }

                sb.Append(IndexTable[b]);
            }

            AppendPadding(bytes.Length, sb);

            return sb.ToString();
        }

        public static string FromBase64(string s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (s == string.Empty) return string.Empty;

            var len1 = s.Length - s.Count(x => x == '=');
            var len2 = len1 * 6;
            var bytes = new byte[len2 / 8];
            var bits = BuildBitArray(len1, len2, s);

            for (int l = 0, r = 8, j = 0; r <= bits.Length; r += 8, j++)
            {
                var b = new byte();
                for (; l < r; l++)
                {
                    b = (byte) (b | Convert.ToByte(bits[l]));
                    if (l != r - 1)
                    {
                        b = (byte)(b << 1);
                    }
                }

                bytes[j] = b;
            }

            return Encoding.UTF8.GetString(bytes);
        }

        private static BitArray BuildBitArray(byte[] bytes)
        {
            var len = bytes.Length * 8;
            var re = len % 6;
            if (re != 0)
            {
                len = len + (6 - re);
            }

            var result = new BitArray(len);
            for (var i = 0; i < bytes.Length; i++)
            {
                var bits = bytes[i].GetBits();
                for (var l = 0; l < bits.Length; l++)
                {
                    result.Set(i * 8 + l, bits[l]);
                }
            }

            return result;
        }

        private static BitArray BuildBitArray(int len1, int len2, string s)
        {
            var result = new BitArray(len2);
            for (var i = 0; i < len1; i++)
            {
                var bits = GetBits((byte)IndexTable.IndexOf(s[i]));
                for (int l = 2, k = 0; l < bits.Length; l++, k++)
                {
                    result.Set(i * 6 + k, bits[l]);
                }
            }

            return result;
        }

        private static void AppendPadding(int len, StringBuilder sb)
        {
            var re = len % 3;
            if (re != 0)
            {
                for (var i = 3 - re; i > 0; i--)
                {
                    sb.Append('=');
                }
            }
        }

        private static bool[] GetBits(this byte b)
        {
            var bits = new bool[8];
            for (var i = 7; i >= 0; i--)
            {
                bits[i] = b % 2 != 0;
                b = (byte) (b >> 1);
            }

            return bits;
        }
    }
}