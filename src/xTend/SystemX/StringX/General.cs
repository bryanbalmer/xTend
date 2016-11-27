using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTend.SystemX.CharX;

namespace xTend.SystemX.StringX
{
    public static class StringExtensions
    {
        public static int Count(this string str, string countStr)
        {
            if (String.IsNullOrEmpty(countStr))
                return 0;

            return (str.Length - str.Remove(countStr).Length) / countStr.Length;
        }

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

        public enum EncodingType
        {
            ASCII,
            Unicode,
            UTF7,
            UTF8,
            UTF32
        }

        public static byte[] GetBytes(this string str, EncodingType type = EncodingType.ASCII)
        {
            switch (type)
            {
                case EncodingType.ASCII:
                    return Encoding.ASCII.GetBytes(str);
                case EncodingType.Unicode:
                    return Encoding.Unicode.GetBytes(str);
                case EncodingType.UTF7:
                    return Encoding.UTF7.GetBytes(str);
                case EncodingType.UTF8:
                    return Encoding.UTF8.GetBytes(str);
                case EncodingType.UTF32:
                    return Encoding.UTF32.GetBytes(str);
                default:
                    return Encoding.ASCII.GetBytes(str);
            }
        }

        public static string EncodeTo64(this string str, EncodingType type = EncodingType.ASCII)
        {
            return Convert.ToBase64String(str.GetBytes(type));
        }
    }
}
