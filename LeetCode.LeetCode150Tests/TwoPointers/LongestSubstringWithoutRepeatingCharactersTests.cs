using LeetCode.LeetCode150.SlidingWindow;

namespace LeetCode.LeetCode150Tests.TwoPointers;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("p", 1)]
    [InlineData(" ", 1)]
    public void LengthOfLongestSubstring(string s, int expected)
    {
        var solution = new LongestSubstringWithoutRepeatingCharacters.Solution();

        var result = solution.LengthOfLongestSubstring(s);

        Assert.Equal(expected, result);
    }
}
