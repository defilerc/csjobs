using Xunit;
using CodeFights;

namespace CodeFightsTests
{
    public class BankRequestsTests
    {
        [Fact]
        public void Test1() 
        {
            var algo = new BankRequests();

            var result = algo.bankRequests(
                new[] {10, 100, 20, 50, 30},
                new[] { "withdraw 2 10", "transfer 5 1 20", "deposit 5 20", "transfer 3 4 15" });

        }
    }
}