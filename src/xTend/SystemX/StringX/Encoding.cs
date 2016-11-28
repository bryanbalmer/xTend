using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xTend.SystemX.StringX
{
    public enum EncodingType
    {
        ASCII,
        Unicode,
        UTF7,
        UTF8,
        UTF32
    }

    public static partial class StringExtensions
    {
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
