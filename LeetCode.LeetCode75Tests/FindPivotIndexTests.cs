using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class FindPivotIndexTests
{
    [Theory]
    [InlineData(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 2, 3 }, -1)]
    [InlineData(new int[] { 2, 1, -1 }, 0)]
    [InlineData(new int[] { 1, -1, 2 }, 2)]
    public void LargestAltitudeTest(int[] nums, int expected)
    {
        var solution = new FindPivotIndex.Solution();

        var result = solution.PivotIndex(nums);

        Assert.Equal(expected, result);
    }
}
