using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xTend.SystemX.CharX;
using Xunit;

namespace xTend.Tests.Chars
{
    public class CharTests
    {
        [Fact]
        public void TestToUpper()
        {
            char test = 'a';
            Assert.Equal(test.ToUpper(), 'A');
        }
    }
}
