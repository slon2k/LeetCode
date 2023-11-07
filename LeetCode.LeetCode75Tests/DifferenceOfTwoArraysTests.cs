using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class DifferenceOfTwoArraysTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 }, new int[] { 1, 3 }, new int[] { 4, 6 })]
    [InlineData(new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2 }, new int[] { 3 }, new int[] { })]
    public void ProductExceptSelfTest(int[] a1, int[] a2, int[] expected1, int[] expected2)
    {
        var solution = new DifferenceOfTwoArrays.Solution();

        var result = solution.FindDifference(a1, a2).ToList();

        Assert.Equal(2, result.Count);
        Assert.Equal(expected1, result[0]);
        Assert.Equal(expected2, result[1]);
    }
}
