using static LeetCode.LeetCode150.LinkedList.ReverseLinkedList;

namespace LeetCode.LeetCode150Tests.LinkedList;

public class ReverseLinkedListTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 4, new int[] { 1, 4, 3, 2, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 1, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 5, new int[] { 1, 2, 5, 4, 3 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 3, new int[] { 3, 2, 1, 4, 5 })]
    [InlineData(new int[] { 5 }, 1, 1, new int[] { 5 })]
    public void SolutionTest(int[] values, int left, int right, int[] expected)
    {
        var solution = new Solution();
        
        var head = new ListNode(values);

        var result = solution.ReverseBetween(head, left, right);

        Assert.Equal(expected, result.Nodes.ToArray());
    }
}
