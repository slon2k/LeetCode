using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class CanPlaceFlowersTests
{
    [Theory]
    [InlineData(new int[] { 1, 0, 0, 0, 1 }, 1, true)]
    [InlineData(new int[] { 1, 0, 0, 0, 1 }, 2, false)]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2, true)]
    [InlineData(new int[] { 1, 0, 0, 0, 0 }, 2, true)]
    [InlineData(new int[] { 0, 0, 0, 0, 1 }, 2, true)]
    [InlineData(new int[] { 0, 0, 0, 0, 0 }, 3, true)]
    [InlineData(new int[] { 0, 0, 0, 0, 0 }, 4, false)]
    [InlineData(new int[] { 0 }, 1, true)]
    [InlineData(new int[] { 0, 0 }, 1, true)]
    [InlineData(new int[] { 0, 0, 0 }, 2, true)]
    public void CanPlaceFlowersTest(int[] candies, int extraCandies, bool expected)
    {
        var solution = new CanPlaceFlowers.Solution();

        var result = solution.CanPlaceFlowers(candies, extraCandies);

        Assert.Equal(expected, result);
    }
}
