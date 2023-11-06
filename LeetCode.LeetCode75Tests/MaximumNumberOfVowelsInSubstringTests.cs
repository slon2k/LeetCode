using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MaximumNumberOfVowelsInSubstringTests
{
    [Theory]
    [InlineData("abciiidef", 3, 3)]
    [InlineData("aeiou", 2, 2)]
    [InlineData("leetcode", 3, 2)]
    public void MaxVowelsTest(string s, int k, int expected)
    {
        var solution = new MaximumNumberOfVowelsInSubstring.Solution();

        var result = solution.MaxVowels(s, k);

        Assert.Equal(expected, result);
    }
}
