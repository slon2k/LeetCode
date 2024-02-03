using LeetCode.LeetCode150.LinkedList;

namespace LeetCode.LeetCode150.DivideAndConquer;

public class SortList
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            (ListNode ? first, ListNode ? second) = Split(head);

            first = SortList(first);
            second = SortList(second);

            var merged = Merge(first, second);

            return merged;
        }

        private ListNode Merge(ListNode? node1, ListNode? node2)
        {
            ListNode head = new();

            ListNode tail = head;

            while ((node1 is not null) || (node2 is not null))
            {
                if (node2 is null)
                {
                    tail.next = node1;
                    break;
                }

                if (node1 is null)
                {
                    tail.next = node2;
                    break;
                }

                if (node1.val < node2.val)
                {
                    tail.next = new(node1.val);
                    node1 = node1.next;
                } else
                {
                    tail.next = new(node2.val);
                    node2 = node2.next;
                }

                tail = tail.next;
            }

            return head.next;
        }

        private (ListNode? first, ListNode? second) Split(ListNode head)
        {
            if (head is null)
            {
                return (null, null);
            }

            if (head.next is null)
            {
                return (head, head.next);
            }

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast.next is not null)
            {
                slow = slow.next ?? slow;
                fast = fast.next ?? fast;
                fast = fast.next ?? fast;
            }

            ListNode? second = slow.next;
            slow.next = null;

            return (head, second);
        }
    }
}
