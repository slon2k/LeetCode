using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MaximumAverageSubarrayITests
{
    [Theory]
    [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.7500)]
    [InlineData(new int[] { 5 }, 1, 5.0000)]
    public void FindMaxAverageTest(int[] nums, int k, double expected)
    {
        var solution = new MaximumAverageSubarrayI.Solution();

        var result = solution.FindMaxAverage(nums, k);

        Assert.Equal(expected, result);
    }
}
