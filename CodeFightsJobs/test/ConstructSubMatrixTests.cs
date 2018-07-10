using CodeFights;
using Xunit;

namespace CodeFightsTests
{
    public class ConstructSubMatrixTests
    {
        [Fact]
        public void Test1() 
        {
            var algo = new ConstructSubMatrix();
            var matrix = new [] { 
                new[] { 1, 0, 0, 2 },
                new[] { 0, 5, 0, 1 },
                new[] { 0, 0, 3, 5 }
            };

            var result = algo.ConstructSubmatrix(matrix, new[] {1}, new[] {0,2});

            Assert.Equal(new[] { new[] { 0, 2}, new[] { 0, 5 }}, result);
        }
    }
}