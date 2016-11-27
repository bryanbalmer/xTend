using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xTend.SystemX.CharX
{
    public static class CharExtensions
    {
        public static char ToUpper(this char c)
        {
            return Char.ToUpper(c);
        }

        public static char ToLower(this char c)
        {
            return Char.ToLower(c);
        }

        public static bool IsUpper(this char c)
        {
            return Char.IsUpper(c);
        }

        public static bool IsLower(this char c)
        {
            return Char.IsLower(c);
        }
    }
}
