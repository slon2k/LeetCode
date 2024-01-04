namespace LeetCode.LeetCode150.LinkedList;

public class ReverseNodeGroups
{
    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var nodeK = GetKthNode(head, k);

            if (nodeK is null)
                return head;

            var next = nodeK.next;

            nodeK.next = null;

            var tail = head;

            var result = Reverse(head);

            tail.next = ReverseKGroup(next, k);

            return result;
        }

        private ListNode? GetKthNode(ListNode? head, int k)
        {
            var node = head;

            for (int i = 1; i < k; i++)
            {
                if (node is null)
                {
                    return null;
                }
                node = node.next;
            }

            return node;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode? prev = null;
            ListNode? node = head;

            while (node is not null)
            {
                var next = node.next;
                node.next = prev;
                prev = node;
                node = next;
            }

            return prev;
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
