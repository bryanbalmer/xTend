using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTend.SystemX.StringX;
using Xunit;

namespace xTend.Tests.SystemX.StringX
{
    public class EncodingTests
    {
        [Fact]
        public void StringEncodesTo64()
        {
            var test = "Encode me!";
            var testBytes = Encoding.ASCII.GetBytes(test);
            var expected = Convert.ToBase64String(testBytes);

            Assert.Equal(expected, test.EncodeTo64());
        }
    }
}
