namespace LeetCode.LeetCode150.LinkedList;

public class LinkedListCycle
{

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast is not null &&  fast.next is not null)
            {
                slow = slow.next;

                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
