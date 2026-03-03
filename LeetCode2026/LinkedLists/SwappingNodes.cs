namespace LeetCode2026.LinkedLists;

// 1721. Swapping Nodes in a Linked List
// You are given the head of a linked list, and an integer k.
// Swap the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).
// Return the head of the linked list after the swap.

public class SwappingNodes
{
    public class Solution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            // Start two pointers at the head
            ListNode first = head, second = head, kthFromStart, kthFromEnd;


            // Move the first pointer k-1 steps to find the kth node from the beginning
            for (int i = 1; i < k; i++)
            {
                first = first.next;
            }

            kthFromStart = first;

            // Move the first pointer to the end, and move the second pointer at the same pace
            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }

            kthFromEnd = second;

            // Swap the values of the two nodes
            (kthFromEnd.val, kthFromStart.val) = (kthFromStart.val, kthFromEnd.val);
            return head;
        }
    }
}

