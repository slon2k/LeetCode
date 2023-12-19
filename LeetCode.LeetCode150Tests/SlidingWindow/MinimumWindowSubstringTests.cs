using LeetCode.LeetCode150.SlidingWindow;

namespace LeetCode.LeetCode150Tests.SlidingWindow;

public class MinimumWindowSubstringTests
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("ADOBECODEBANC", "ABCC", "CODEBANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    public void MinWindowTest(string s, string t, string expected)
    {
        var solution = new MinimumWindowSubstring.Solution();

        var result = solution.MinWindow(s, t);

        Assert.Equal(expected, result);
    }
}
