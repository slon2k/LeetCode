using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class LongestCommonSubsequenceTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("ace", "abcde", 3)]
        [InlineData("abc", "abc", 3)]
        [InlineData("abc", "def", 0)]
        [InlineData("abacd", "tattacx", 3)]
        [InlineData("bsbininm", "jmjkbkjkv", 1)]
        public void LongestCommonSubsequenceTest(string text1, string text2, int expected)
        {
            var solution = new LongestCommonSubsequence.Solution();

            var result = solution.LongestCommonSubsequence(text1, text2);

            Assert.Equal(expected, result);
        }
    }
}
