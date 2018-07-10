using CodeFights;
using Xunit;

namespace CodeFightsTests
{
    public class StringAnagramTests
    {
        [Fact]
        public void Test1() 
        {
            var algo = new StringAnagram();

            var result = algo.MakeAnagram("abc", "cba");
            Assert.Equal(0, result);

            result = algo.MakeAnagram("cde", "abc");
            Assert.Equal(4, result);
        }
    }
}