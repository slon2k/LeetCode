namespace LeetCode.LeetCode75;

public class DeleteMiddleNode
{
    public class Solution
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            int count = GetNodes(head).Count();

            if (count < 2)
            {
                return null;
            }

            int middle = count / 2;

            var node = head;

            for (int i = 1; i < middle; i++)
            {
                node = node?.next;
            }

            var middleNode = node.next;

            node.next = middleNode.next;

            return head;
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

        private IEnumerable<ListNode> GetNodes(ListNode head)
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
