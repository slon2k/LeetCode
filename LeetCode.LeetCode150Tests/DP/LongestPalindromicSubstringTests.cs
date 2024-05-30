using LeetCode.LeetCode150.DP;

namespace LeetCode.LeetCode150Tests.DP;

public class LongestPalindromicSubstringTests
{
    [Theory]
    [InlineData("babad", "aba")]
    [InlineData("cbbd", "bb")]
    public void LongestPalindrome(string s, string expected)
    {
        var solution = new LongestPalindromicSubstring.Solution();

        var result = solution.LongestPalindrome(s);

        Assert.Equal(expected, result);
    }
}
