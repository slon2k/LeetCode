namespace LeetCode.LeetCode75;

public class MaximumTwinSumLinkedList
{
    public class Solution
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

        public int PairSum(ListNode head)
        {
            var list = GetNodes(head).Select(x => x.val).ToList();

            int left = 0, right = list.Count - 1;

            int max = int.MinValue;

            while (left < right)
            {
                int sum = list[left++] + list[right--];
                
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;

        }

        public ListNode ReverseList(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            var node = head.next;

            var reversed = head;

            reversed.next = null;

            while (node is not null)
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
