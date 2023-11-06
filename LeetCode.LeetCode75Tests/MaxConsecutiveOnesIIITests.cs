using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MaxConsecutiveOnesIIITests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
    [InlineData(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 0, 0 }, 0, 3)]
    public void LongestOnesTest(int[] nums, int k, int expected)
    {
        var solution = new MaxConsecutiveOnesIII.Solution();

        var result = solution.LongestOnes(nums, k);

        Assert.Equal(expected, result);
    }
}
