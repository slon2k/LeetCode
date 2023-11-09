namespace LeetCode.LeetCode75;

public class ReverseLinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            var node = head;
            var prev = head;

            while (node.next is not null)
            {
                prev = node;
                node = node.next;
            }

            prev.next = null;

            node.next = ReverseList(head);

            return node;
        }

        public ListNode ReverseListIterative(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            var node = head.next;

            var reversed = head;

            reversed.next = null;

            while(node is not null)
            {
                var next = node.next;
                var current = node;

                current.next = reversed;

                reversed = current;
                
                node = next;
            }

            return reversed;
        }

        public static ListNode CreateList(IEnumerable<int> values)
        {
            ListNode prev = null;
            ListNode head = null;

            foreach (var item in values)
            {
                var node = new ListNode(item);

                if (prev is null)
                {
                    head = node;
                    prev = node;

                    continue;
                }

                prev.next = node;

                prev = node;
            }

            return head;
        }

        public static IEnumerable<ListNode> GetNodes(ListNode head)
        {
            var node = head;

            while (node != null)
            {
                yield return node;
                node = node.next;
            }
        }
    }
}
