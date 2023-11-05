using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ReverseWordsInStringTests
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void ReverseWordsInStringTest(string str, string expected)
    {
        var solution = new ReverseWordsInString.Solution();

        var result = solution.ReverseWords(str);

        Assert.Equal(expected, result);
    }
}
