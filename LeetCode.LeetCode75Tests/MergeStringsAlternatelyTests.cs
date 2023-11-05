using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MergeStringsAlternatelyTests
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternatelyTest(string word1, string word2, string expected)
    {
        var solution = new MergeStringsAlternately.Solution();
        
        var result = solution.MergeAlternately(word1, word2);

        Assert.Equal(expected, result);
    }
}
