using LeetCode.LeetCode150.LinkedList;

namespace LeetCode.LeetCode150.DivideAndConquer;

public class MergeSortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            if (lists.Length == 1)
            {
                ListNode head = lists[0];
                return head;
            }

            if (lists.Length == 2)
            {
                return Merge(lists[0], lists[1]);
            }

            int middle = lists.Length / 2;

            var first = MergeKLists(lists[..middle]);
            var second = MergeKLists(lists[middle..]);

            return Merge(first, second);
        }

        private static ListNode? Merge(ListNode? node1, ListNode? node2)
        {
            if (node1 is null)
            {
                return node2;
            }

            if (node2 is null)
            {
                return node1;
            }

            ListNode head;

            if (node1.val < node2.val)
            {
                head = node1;
                node1 = node1.next;
            }
            else
            {
                head = node2;
                node2 = node2.next;
            }

            head.next = Merge(node1, node2);

            return head;
        }
    }
}
