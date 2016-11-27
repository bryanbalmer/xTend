using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xTend.SystemX.StringX;
using Xunit;

namespace xTend.Tests.Strings
{
    public class StringTests
    {
        [Fact]
        public void StringCounts()
        {
            var test = "This is a test sentence.  We are going to test how many times certain substrings appear.";

            Assert.Equal(test.Count("test"), 2);
            
        }

        [Fact]
        public void StringCapitalizes()
        {
            Assert.Equal("bryan".Capitalize(), "Bryan");
            Assert.Equal("bRYAN".Capitalize(), "BRYAN");
            Assert.Equal("Bryan".Capitalize(), "Bryan");
        }

        [Fact]
        public void StringSwapsCase()
        {
            Assert.Equal("cRaZyCaSiNg".SwapCase(), "CrAzYcAsInG");
            Assert.Equal("ABCDEFG".SwapCase(), "abcdefg");
            Assert.Equal(String.Empty.SwapCase(), String.Empty);
        }

        [Fact]
        public void StringRemoves()
        {
            var test = "GOOD GOOD BAD GOOD BAD";
            Assert.Equal(test.Remove("BAD"), "GOOD GOOD  GOOD ");
        }

        [Fact]
        public void StringSnipsEnd()
        {
            var test = "I only want the last bit of this.";
            Assert.Equal(test.SnipEnd(17), "last bit of this.");
        }

        [Fact]
        public void StringMultiplies()
        {
            var test = "HI";
            Assert.Equal(test.Multiply(1), test);
            Assert.Equal(test.Multiply(3), "HIHIHI");
            Assert.Equal(test.Multiply(0), String.Empty);
        }
    }
}
