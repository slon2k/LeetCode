using LeetCode.LeetCode150.DP;

namespace LeetCode.LeetCode150Tests.DP;

public class LongestIncreasingSubsequenceTests
{
    [Theory]
    [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
    [InlineData(new int[] { 0, 1, 0, 3, 2, 3 }, 4)]
    [InlineData(new int[] { 4, 10, 4, 3, 8, 9 }, 3)]
    [InlineData(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 1)]
    public void LengthOfLISTest(int[] nums, int expected)
    {
        var solution = new LongestIncreasingSubsequence.Solution();

        var result = solution.LengthOfLIS(nums);

        Assert.Equal(expected, result);
    }
}
