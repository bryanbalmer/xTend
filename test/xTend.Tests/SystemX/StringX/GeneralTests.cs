using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xTend.SystemX.StringX;
using Xunit;

namespace xTend.Tests.SystemX.StringX
{
    public class GeneralTests
    {
        [Fact]
        public void StringCounts()
        {
            var test = "This is a test sentence.  We are going to test how many times certain substrings appear.";

            Assert.Equal(2, test.Count("test"));
            Assert.Equal(0, test.Count(String.Empty));
        }
    }
}
