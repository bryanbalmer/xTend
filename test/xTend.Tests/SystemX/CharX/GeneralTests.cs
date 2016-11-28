using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xTend.SystemX.CharX;
using Xunit;

namespace xTend.Tests.SystemX.CharX
{
    public class GeneralTests
    {
        [Fact]
        public void TestToUpper()
        {
            char test = 'a';
            Assert.Equal('A', test.ToUpper());
        }
    }
}
