using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class StringCompressionTests
{
    [Theory]
    [InlineData(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6, "a2b2c3")]
    [InlineData(new char[] { 'a' }, 1, "a")]
    [InlineData(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4, "ab12")]
    public void CompressTest(char[] chars, int expected, string expectedString)
    {
        var solution = new StringCompression.Solution();

        var result = solution.Compress(chars);

        Assert.Equal(expected, result);

        for (int i = 0; i < result; i++)
        {
            Assert.Equal(expectedString[i], chars[i]);
        }
    }
}
