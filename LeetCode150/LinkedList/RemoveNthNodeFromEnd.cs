namespace LeetCode.LeetCode150.LinkedList;

public class RemoveNthNodeFromEnd
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode right = head;
            
            for (int i = 0; i < n; i++)
            {
                if (right.next is null)
                {
                    return DeleteHead(head);
                }
                
                right = right.next;
            }

            var left = head;

            while (right.next is not null)
            {
                right = right.next;
                left = left.next;
            }

            DeleteNext(left);

            return head;
        }

        private void DeleteNext(ListNode node)
        {
            if (node is null || node.next is null)
            {
                return;
            }

            node.next = node.next.next;
        }

        private ListNode? DeleteHead(ListNode head)
        {
            if (head?.next is not null)
            {
                return head.next;
            } else
            {
                return null;
            }
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
