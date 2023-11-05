using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ProductOfArrayExceptSelfTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
    public void ProductExceptSelfTest(int[] input, int[] expected)
    {
        var solution = new ProductOfArrayExceptSelf.Solution();

        var result = solution.ProductExceptSelf(input);

        Assert.Equal(expected, result);
    }
}
