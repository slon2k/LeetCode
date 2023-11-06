using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MaxNumberKSumPairsTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5, 2)]
    [InlineData(new int[] { 3, 1, 3, 4, 3 }, 6, 1)]
    public void MaxOperationsTest(int[] numbers, int k, int expected)
    {
        var solution = new MaxNumberKSumPairs.Solution();

        var result = solution.MaxOperations(numbers, k);

        Assert.Equal(expected, result);
    }
}
