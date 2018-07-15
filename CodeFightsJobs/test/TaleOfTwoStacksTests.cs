using Xunit;
using CodeFights;

namespace CodeFightsTests
{
    public class TaleOfTwoStacksTests
    {
        [Fact]
        public void Test1() 
        {
            var algo = new TaleOfTwoStacks();

            algo.RunQuery("1 1");
            algo.RunQuery("1 2");
            algo.RunQuery("2");
            algo.RunQuery("1 3");
            algo.RunQuery("2");
            algo.RunQuery("1 4");
        }
    }
}