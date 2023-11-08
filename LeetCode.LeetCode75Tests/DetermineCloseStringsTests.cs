using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class DetermineCloseStringsTests
{
    public class SolutionTest
    {

        [Theory]
        [InlineData("abc", "bca", true)]
        [InlineData("a", "aa", false)]
        [InlineData("cabbba", "abbccc", true)]
        [InlineData("cabbba", "aabbcc", false)]
        [InlineData("aaabbbbccddeeeeefffff", "aaaaabbcccdddeeeeffff", false)]
        public void CloseStringsTest(string word1, string word2, bool expected)
        {
            var solution = new DetermineCloseStrings.Solution();

            var result = solution.CloseStrings(word1, word2);

            Assert.Equal(expected, result);
        }
    }
}
