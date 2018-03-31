using System;
using Xunit;

using ProdCode;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, MyMath.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, MyMath.Add(2, 2));
        }
    }
}
