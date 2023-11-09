using static LeetCode.LeetCode75.DeleteMiddleNode.Solution;

namespace LeetCode.LeetCode75;

public class OddEvenLinkedList
{
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }

            var headEven = head.next;
            
            var currentOdd = head;
            
            var currentEven = head.next;

            while (currentOdd?.next is not null) 
            {
                var nextOdd = currentEven?.next;

                var nextEven = nextOdd?.next;

                currentOdd.next = nextOdd;

                currentEven.next = nextEven;

                currentEven = nextEven;

                if (nextOdd is null)
                {                   
                    break;
                }

                currentOdd = nextOdd;
            }

            currentOdd.next = headEven;; 
            
            return head;
        }

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
