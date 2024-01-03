namespace LeetCode.LeetCode150.LinkedList;

public class RotateList
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            int count = 1;

            var node = head;

            while (node.next != null)
            {
                count++;
                node = node.next;
            }

            k %= count;
            node.next = head;
            node = head;
            
            for (int i = 0; i < count - k; i++)
            {
                node = node.next;
            }

            var newHead = node.next;
            node.next = null;

            return newHead;
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
