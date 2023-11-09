using LeetCode.LeetCode75;
using static LeetCode.LeetCode75.OddEvenLinkedList.Solution;

namespace LeetCode.LeetCode75Tests;

public class OddEvenLinkedListTests
{
    public class Solution
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] { 1, 3, 5, 2, 4 })]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6}, new int[] { 1, 3, 5, 2, 4, 6 })]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6, 7}, new int[] { 1, 3, 5, 7, 2, 4, 6 })]
        public void OddEvenListTest(int[] list, int[] expected)
        {
            var solution = new OddEvenLinkedList.Solution();

            var head = new OddEvenLinkedList.Solution.ListNode(list[0]);

            var node = head;

            for (int i = 1; i < list.Length; i++)
            {
                node.next = new ListNode(list[i]);
                node = node.next;
            }

            var result = solution.OddEvenList(head);

            Assert.Equal(expected, GetNodes(result).Select(x => x.val));
        }
    }
}
