using LeetCode.LeetCode150.SlidingWindow;

namespace LeetCode.LeetCode150Tests.SlidingWindow;

public class MinimumSizeSubarraySumTests
{
    [Theory]
    [InlineData(7, new int[] { 2, 3, 1, 2, 4, 3 }, 2)]
    [InlineData(213, new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 }, 8)]
    public void  MinSubArrayLen(int target, int[] nums, int expected)
    {
        var solution = new MinimumSizeSubarraySum.Solution();

        var result = solution.MinSubArrayLen(target, nums);

        Assert.Equal(expected, result);
    }
}
