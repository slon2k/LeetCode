namespace LeetCode2026.LinkedLists;

// 24. Swap Nodes in Pairs
// Given a linked list, swap every two adjacent nodes and return its head. 
// You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

public class SwapNodesInPairs
{
    public class Solution {
        public ListNode SwapPairs(ListNode head) 
        {
            if (head == null || head.next == null)
                return head;
            
            ListNode first = head;
            ListNode second = head.next;
            first.next = SwapPairs(second.next);
            second.next = first;
            return second;
        }
    }
}