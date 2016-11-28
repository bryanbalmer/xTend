using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTend.SystemX.CharX;

namespace xTend.SystemX.StringX
{
    public static partial class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            var firstChar = str.First().ToUpper();
            return firstChar + str.Substring(1);
        }

        public static string SwapCase(this string str)
        {
            var result = new StringBuilder();

            foreach (var c in str)
            {
                if (c.IsUpper())
                    result.Append(c.ToLower());
                else if (c.IsLower())
                    result.Append(c.ToUpper());
                else
                    result.Append(c);
            }

            return result.ToString();
        }

        public static string Remove(this string str, params string[] removeStr)
        {
            var result = str;

            foreach (var rem in removeStr)
            {
                result = result.Replace(rem, String.Empty);
            }

            return result;
        }

        public static string SnipEnd(this string str, int count)
        {
            if (count > str.Length)
                count = str.Length;

            return str.Substring(str.Length - count, count);
        }

        public static string GetMaxSubstring(this string str, int maxChars, bool trim = true)
        {
            var result = (trim) ? str.Trim() : str;

            if (result.Length > maxChars)
                return result.Substring(0, maxChars);
            else
                return result;
        }

        public static string Multiply(this string str, int times)
        {
            var result = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                result.Append(str);
            }

            return result.ToString();
        }
    }
}
