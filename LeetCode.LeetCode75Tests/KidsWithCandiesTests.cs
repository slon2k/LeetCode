using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class KidsWithCandiesTests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool[] { true, true, true, false, true })]
    [InlineData(new int[] { 4, 2, 1, 1, 2 }, 1, new bool[] { true, false, false, false, false })]
    [InlineData(new int[] { 12, 1, 12 }, 10, new bool[] { true, false, true})]
    public void KidsWithCandiesTest(int[] candies, int extraCandies, bool[] expected)
    {
        var solution = new KidsWithCandies.Solution();

        var result = solution.KidsWithCandies(candies, extraCandies);

        Assert.Equal(expected.ToList(), result);
    }
}