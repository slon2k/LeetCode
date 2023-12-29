namespace LeetCode.LeetCode150.LinkedList;

public class AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new();

            var current = head;

            int transfer = 0;

            while (l1 is not null || l2 is not null)
            {
                int value = (l1?.val ?? 0) + (l2?.val ?? 0) + transfer;

                transfer = value / 10;

                value %= 10;

                current.next = new ListNode(value);

                current = current.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (transfer > 0)
            {
                current.next = new ListNode(transfer);
            }

            return head.next ?? new ListNode(0);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
