using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;
public class IsSubsequenceTests
{
    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    [InlineData("abcd", "abbbaccaaaabcccad", true)]
    public void IsSubsequenceTest(string word1, string word2, bool expected)
    {
        var solution = new IsSubsequence.Solution();

        var result = solution.IsSubsequence(word1, word2);

        Assert.Equal(expected, result);
    }
}
