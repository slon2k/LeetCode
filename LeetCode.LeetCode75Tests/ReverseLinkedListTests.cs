using static LeetCode.LeetCode75.ReverseLinkedList;

namespace LeetCode.LeetCode75Tests;

public class ReverseLinkedListTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void ReverseListTest(int[] list, int[] expected)
    {
        var solution = new Solution();

        var result = solution.ReverseList(Solution.CreateList(list));

        Assert.Equal(expected, Solution.GetNodes(result).Select(x => x.val));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void ReverseListIterativeTest(int[] list, int[] expected)
    {
        var solution = new Solution();

        var result = solution.ReverseListIterative(Solution.CreateList(list));

        Assert.Equal(expected, Solution.GetNodes(result).Select(x => x.val));
    }
}
