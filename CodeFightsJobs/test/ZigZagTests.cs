using System;
using Xunit;
using CodeFights;

namespace CodeFightsTests
{
    public class UnitTest1
    {
        [Fact]
        public void MyTest()
        {
            var algo = new ZigZagAlgo();

            var length = algo.ZigZag(new[] { 1});
            Assert.Equal(1, length);

            length = algo.ZigZag(new[] { 1, 2, 1, 2});
            Assert.Equal(4, length);

            length = algo.ZigZag(new[] { 4, 3, 4, 3});
            Assert.Equal(4, length);

            length = algo.ZigZag(new[] { 4, 4 });
            Assert.Equal(1, length);

            length = algo.ZigZag(new[] { 4, 3 });
            Assert.Equal(2, length);

            length = algo.ZigZag(new[] { 3, 4 });
            Assert.Equal(2, length);

            length = algo.ZigZag(new[] { 8, 4, 2, 1, 2, 4, 2, 5, 7, 8, 7, 8, 4, 5, 0, 10 });
            Assert.Equal(8, length);
        }
    }
}
