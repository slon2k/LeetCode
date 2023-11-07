using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class LongestSubarrayAfterDeletingOneElementTests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1 }, 2)]
    [InlineData(new int[] { 0, 0 }, 0)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1, 0 }, 1)]
    [InlineData(new int[] { 0, 1 }, 1)]
    [InlineData(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
    [InlineData(new int[] { 1, 1, 0, 1}, 3)]
    [InlineData(new int[] { 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0 }, 3)]
    public void LongestSubarrayTest(int[] numbers, int expected)
    {
        var solution = new LongestSubarrayAfterDeletingOneElement.Solution();

        var result = solution.LongestSubarray(numbers);

        Assert.Equal(expected, result);
    }
}
