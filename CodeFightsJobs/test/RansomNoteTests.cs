using CodeFights;
using Xunit;

namespace CodeFightsTests
{
    public class RansomNoteTests
    {
        [Fact]
        public void Test1() 
        {
            var result = RansomNote.checkMagazine(
                new[] {"give", "me", "one", "grand", "today", "night"},
                new[] {"give", "one", "grand", "today"});

            Assert.True(result);

            result = RansomNote.checkMagazine(
                new[] {"not", "enough", "Words"},
                new[] {"not", "enough", "words"});

            Assert.False(result);
        }
    }
}