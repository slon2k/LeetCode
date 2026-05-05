namespace LeetCode2026.LinkedLists;

// 61. Rotate List
// Given the head of a linked list, rotate the list to the right by k places.

public class RotateList
{
    public ListNode RotateRight(ListNode head, int k) 
    {
        if (head == null || head.next == null || k == 0)
            return head;

        // Compute the length of the list and get the tail node
        ListNode tail = head;
        int length = 1;
        while (tail.next != null)
        {
            tail = tail.next;
            length++;
        }

        // Connect the tail to the head to make it circular
        tail.next = head;

        k %= length;
        
        if (k == 0)
        {
            tail.next = null;
            return head;
        }

        int stepsToNewHead = length - k;
        ListNode newTail = head;
        for (int i = 1; i < stepsToNewHead; i++)
        {
            newTail = newTail.next;
        }

        ListNode newHead = newTail.next;

        // Break the circle
        newTail.next = null;

        return newHead;
    }
}