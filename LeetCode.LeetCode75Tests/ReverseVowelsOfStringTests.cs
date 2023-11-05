using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ReverseVowelsOfStringTests
{
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("hEllo", "hollE")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("leetcOde", "leOtcede")]
    public void ReverseVowelsTest(string str, string expected)
    {
        var solution = new ReverseVowelsOfString.Solution();

        var result = solution.ReverseVowels(str);

        Assert.Equal(expected, result);
    }
}
