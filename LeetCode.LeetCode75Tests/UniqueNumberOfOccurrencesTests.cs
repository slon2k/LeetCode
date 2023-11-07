using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class UniqueNumberOfOccurrencesTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1, 1, 3 }, true)]
    [InlineData(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
    [InlineData(new int[] { 1, 2 }, false)]
    public void UniqueOccurrencesTest(int[] data, bool expected)
    {
        var solution = new UniqueNumberOfOccurrences.Solution();

        var result = solution.UniqueOccurrences(data);

        Assert.Equal(expected, result);
    }
}
