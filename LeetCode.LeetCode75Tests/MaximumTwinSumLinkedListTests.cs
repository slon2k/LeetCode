using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MaximumTwinSumLinkedListTests
{
    [Theory]
    [InlineData(new int[] { 4, 2, 2, 3 }, 7)]
    [InlineData(new int[] { 5, 4, 2, 1 }, 6)]
    [InlineData(new int[] { 1, 100000 }, 100001)]
    public void PairSumTest(int[] list, int expected)
    {
        var solution = new MaximumTwinSumLinkedList.Solution();

        var result = solution.PairSum(MaximumTwinSumLinkedList.Solution.CreateList(list));

        Assert.Equal(expected, result);
    }
}

