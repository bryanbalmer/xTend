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
        public static int Count(this string str, string countStr)
        {
            if (String.IsNullOrEmpty(countStr))
                return 0;

            return (str.Length - str.Remove(countStr).Length) / countStr.Length;
        }
    }
}
