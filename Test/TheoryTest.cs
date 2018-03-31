using ProdCode;
using Xunit;

namespace Test
{
    public class TheoryTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TestUsingTheory(int value)
        {
            Assert.True(MyMath.IsOdd(value));
        }
    }
}