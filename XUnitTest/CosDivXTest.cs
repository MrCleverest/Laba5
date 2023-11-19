using System;
using Xunit;
using Laba5;

namespace XUnitTest
{
    public class CosDivXTest
    {
        [Fact]
        public void CikleY_006_0999Returned()
        {
            var cos = new CosDivX(0.06);
            var expectedY = 0.999;
            var actualY = Math.Round(cos.CosDivX_cikle(), 3);
            Assert.Equal(expectedY, actualY);
        }

        [Theory]
        public void RecY_006_0999Returned()
        {
            var cos = new CosDivX(0.06);
            var expectedY = 0.999;
            double actualYRec = 1;
            cos.CosDivX_rec(1, -1, 2, ref actualYRec);
            var roundedYRec = Math.Round(actualYRec, 3);
            Assert.Equal(expectedY, roundedYRec);
        }
    }
}
