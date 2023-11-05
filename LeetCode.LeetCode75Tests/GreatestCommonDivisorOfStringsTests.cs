using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class GreatestCommonDivisorOfStringsTests
{
    [Theory]
    [InlineData("ABC", "ABCABCABC", "ABC")]
    [InlineData("ABCABC", "ABCABCABC", "ABC")]
    [InlineData("ABAB", "ABAB", "ABAB")]
    [InlineData("TEST", "FAIL", "")]
    public void GcdOfStringsTest(string word1, string word2, string expected)
    {
        var solution = new GreatestCommonDivisorOfStrings.Solution();

        var result = solution.GcdOfStrings(word1, word2);

        Assert.Equal(expected, result);
    }
}
