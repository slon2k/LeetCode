namespace LeetCode2026.LinkedLists;

// 160. Intersection of Two Linked Lists
// Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
public class IntersectionTwoLinkedLists
{
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode pointerA = headA;
            ListNode pointerB = headB;

            while (pointerA != pointerB)
            {
                pointerA = (pointerA == null) ? headB : pointerA.next;
                pointerB = (pointerB == null) ? headA : pointerB.next;
            }
            
            return pointerA;
        }
    }
}