using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xTend.SystemX.StringX;
using Xunit;

namespace xTend.Tests.SystemX.StringX
{
    public class StringManipulationTests
    {
        [Fact]
        public void StringCapitalizes()
        {
            Assert.Equal("Bryan", "bryan".Capitalize());
            Assert.Equal("BRYAN", "bRYAN".Capitalize());
            Assert.Equal("Bryan", "Bryan".Capitalize());
        }

        [Fact]
        public void StringSwapsCase()
        {
            Assert.Equal("CrAzYcAsInG", "cRaZyCaSiNg".SwapCase());
            Assert.Equal("abcdefg", "ABCDEFG".SwapCase());
            Assert.Equal(String.Empty, String.Empty.SwapCase());
        }

        [Fact]
        public void StringRemoves()
        {
            var test = "GOOD GOOD BAD GOOD BAD";
            Assert.Equal("GOOD GOOD  GOOD ", test.Remove("BAD"));
        }

        [Fact]
        public void StringSnipsEnd()
        {
            var test = "I only want the last bit of this.";
            Assert.Equal("last bit of this.", test.SnipEnd(17));
        }

        [Fact]
        public void StringMultiplies()
        {
            var test = "HI";
            Assert.Equal(test, test.Multiply(1));
            Assert.Equal("HIHIHI", test.Multiply(3));
            Assert.Equal(String.Empty, test.Multiply(0));
        }
    }
}
