using Xunit;
using CodeFights;

namespace CodeFightsTests
{
    public class BalnacedParenthesesTests
    {
        [Fact]
        public void Test1() 
        {
            var algo = new BalancedParentheses();

            Assert.True(algo.IsBalanced(""));
            Assert.True(algo.IsBalanced("()"));
            Assert.True(algo.IsBalanced("[]"));
            Assert.True(algo.IsBalanced("{}"));
            Assert.True(algo.IsBalanced("({})"));
            Assert.True(algo.IsBalanced("[({})]"));
            Assert.True(algo.IsBalanced("[({})][](({{[]}}))"));
            Assert.True(algo.IsBalanced("[({dont})][care](({{[about] inline text}}))"));

            Assert.False(algo.IsBalanced("["));
            Assert.False(algo.IsBalanced("{"));
            Assert.False(algo.IsBalanced("("));
            Assert.False(algo.IsBalanced("]"));
            Assert.False(algo.IsBalanced("}"));
            Assert.False(algo.IsBalanced(")"));
            Assert.False(algo.IsBalanced(")("));
            Assert.False(algo.IsBalanced("[()])"));
            Assert.False(algo.IsBalanced("[(])"));
            Assert.False(algo.IsBalanced("([()]}"));
        }
    }
}