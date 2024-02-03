using LeetCode.LeetCode150.DivideAndConquer;
using LeetCode.LeetCode150.LinkedList;

namespace LeetCode.LeetCode150Tests.DivideAndConquer;

public class SortListTests
{
    [Theory]
    [InlineData(new int[] { 4, 2, 1, 3 }, new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, 5, 3, 4, 0 }, new int[] { -1, 0, 3, 4, 5 })]

    public void SortListTest(int[] list, int[] expected)
    {
        var solution = new SortList.Solution();

        var result = solution.SortList(CreateListNode(list));

        Assert.Equal(expected, ToList(result).ToArray());
    }

    private ListNode? CreateListNode(int[] list)
    {
        if (list.Length == 0)
        {
            return null;
        }

        ListNode head = new ListNode(list[0]);

        ListNode tail = head;

        for (int i = 1; i < list.Length; i++)
        {
            tail.next = new ListNode(list[i]);
            tail = tail.next;
        }

        return head;
    }

    private static IEnumerable<int> ToList(ListNode head)
    {
        var node = head;

        while (node != null)
        {
            yield return node.val; 
            node = node.next;
        }
    }
}
