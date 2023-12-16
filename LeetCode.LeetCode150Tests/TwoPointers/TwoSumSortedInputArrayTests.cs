using LeetCode.LeetCode150.TwoPointers;

namespace LeetCode.LeetCode150Tests.TwoPointers;

public class TwoSumSortedInputArrayTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int [] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int [] { 1, 3 })]
    [InlineData(new int[] { -1, 0 }, -1, new int [] { 1, 2 })]
    [InlineData(new int[] { 5, 25, 75 }, 100, new int [] { 2, 3 })]
    [InlineData(new int[] { 3, 24, 50, 79, 88, 150, 345 }, 200, new int [] { 3, 6 })]
    public void TwoSumTest(int[] numbers, int target, int[] expected)
    {
        var solution = new TwoSumSortedInputArray.Solution();

        var result = solution.TwoSum(numbers, target);

        Assert.Equal(expected, result);
    }
}
