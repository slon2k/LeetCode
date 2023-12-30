namespace LeetCode.LeetCode150.LinkedList;

public class MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var head = new ListNode();

            var current = head;

            while (list1 is not null || list2 is not null)
            {
                if (list1 is null)
                {
                    current.next = new(list2.val);
                    current = current.next;
                    list2 = list2.next;

                    continue;
                }

                if (list2 is null)
                {
                    current.next = new(list1.val);
                    current = current.next;
                    list1 = list1.next;

                    continue;
                }

                if (list1.val < list2.val)
                {
                    current.next = new(list1.val);
                    current = current.next;
                    list1 = list1.next;
                } else
                {
                    current.next = new(list2.val);
                    current = current.next;
                    list2 = list2.next;
                }
            }

            return head.next;
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
    }
}
