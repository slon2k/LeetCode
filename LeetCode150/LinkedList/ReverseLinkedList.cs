
namespace LeetCode.LeetCode150.LinkedList;

public class ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            var node = head;

            int i = 1;

            ListNode? begin = null, end = null, prev = null, next = null, preBegin = null;

            while (node is not null) 
            {
                if (i == left)
                {
                    begin = node;
                    preBegin = prev;
                }

                if (i == right)
                {
                    end = node;
                }

                i++;

                prev = node;

                node = node.next;
            }

            next = end?.next;

            end.next = null;

            Reverse(begin);

            begin.next = next;

            if (preBegin != null)
            {
                preBegin.next = end;

                return head;
            } else
            {
                return end;
            }
        }

        private void Reverse(ListNode? begin)
        {
            if (begin is null)
                return;

            var prev = begin;
            var current = begin.next;
            begin.next = null;

            while (current is not null)
            {
                var next = current.next;
                current.next = prev;
                prev = current; 
                current = next;
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

        private IEnumerable<int> GetNodes()
        {
            var node = this;

            while (node is not null)
            {
                yield return node.val;
                node = node.next;
            }
        }

        public IEnumerable<int> Nodes => GetNodes();
    }
}
