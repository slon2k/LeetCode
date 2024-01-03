namespace LeetCode.LeetCode150.LinkedList;

public class RemoveDuplicates
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var node = head;

            ListNode? prev = null;

            while (node is not null)
            {
                if (!HasDuplicate(node))
                {
                    prev = node;
                    node = node.next;
                    continue;
                }

                node = GetNextValue(node);
                
                if (prev is not null)
                {
                    prev.next = node;
                } else
                {
                    head = node;
                }
            }

            return head;
        }

        private ListNode? GetNextValue(ListNode node)
        {
            if (node is null)
            {
                return null;
            }

            int value = node.val;

            while (node?.val == value) 
            {
                node = node.next;
            }

            return node;
        }

        private bool HasDuplicate(ListNode node)
        {
            if (node.next is null)
            {
                return false;
            }
            return node.next.val == node.val;
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
