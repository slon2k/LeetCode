namespace LeetCode2026.BitManipulation;

// 693. Binary Number with Alternating Bits
// Given a positive integer n, return true if the binary representation of n has alternating bits: namely, if two adjacent bits will always have different values.

public class BinaryNumberWithAlternatingBits
{
    public class Solution 
    {
        // O(1) time, O(1) space
        public bool HasAlternatingBits(int n)
        {
            int x = n ^ (n >> 1);
            return (x & (x + 1)) == 0;
        }
    }
}