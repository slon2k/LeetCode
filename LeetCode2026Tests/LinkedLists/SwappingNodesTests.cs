using Xunit;
using LeetCode2026.LinkedLists;
using System.Collections.Generic;

namespace LeetCode2026Tests.LinkedLists
{
    public class SwappingNodesTests
    {
        [Theory]
        [InlineData(new int[] {1,2,3,4,5}, 2, new int[] {1,4,3,2,5})]
        [InlineData(new int[] {7,9,6,6,7,8,3,0,9,5}, 5, new int[] {7,9,6,6,8,7,3,0,9,5})]
        public void SwapNodes_ReturnsExpected(int[] input, int k, int[] expected)
        {
            var head = ToList(input);
            var solution = new SwappingNodes.Solution();
            var result = solution.SwapNodes(head, k);
            Assert.Equal(expected, ToArray(result));
        }

        private ListNode ToList(int[] arr)
        {
            if (arr.Length == 0) return null;
            var head = new ListNode(arr[0]);
            var current = head;
            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);
                current = current.next;
            }
            return head;
        }

        private int[] ToArray(ListNode head)
        {
            var list = new List<int>();
            var current = head;
            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }
            return list.ToArray();
        }
    }
}
