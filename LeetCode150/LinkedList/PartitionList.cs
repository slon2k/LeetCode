namespace LeetCode.LeetCode150.LinkedList;

public class PartitionList
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head is null)
            {
                return head;
            }

            ListNode head1 = new ListNode();
            ListNode head2 = new ListNode();
            ListNode tail1 = head1;
            ListNode tail2 = head2;

            ListNode node = head;

            while (node != null)
            {
                if (node.val < x)
                {
                    tail1.next = node;
                    node = node.next;
                    tail1 = tail1.next;
                    tail1.next = null;
                }
                else
                {
                    tail2.next = node;
                    node = node.next;
                    tail2 = tail2.next;
                    tail2.next = null;
                }
            }

            if (head1.next is not null)
            {
                tail1.next = head2.next;

                return head1.next;
            } else
            {
                return head2.next;
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

            public ListNode(int[] values)
            {
                if (values.Length == 0)
                {
                    throw new ArgumentException("Array is empty", nameof(values));
                }

                val = values[0];
                next = null;

                var current = this;

                for (int i = 1; i < values.Length; i++)
                {
                    current.next = new ListNode(values[i]);
                    current = current.next;
                }
            }

            public IEnumerable<int> GetNodes()
            {
                var node = this;

                while (node is not null)
                {
                    yield return node.val;
                    node = node.next;
                }
            }

            public int[] Nodes => GetNodes().ToArray();
        }
    }
}
