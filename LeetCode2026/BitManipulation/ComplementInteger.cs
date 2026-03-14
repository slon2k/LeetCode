namespace LeetCode2026.BitManipulation;

// 1009. Complement of Base 10 Integer
// The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.
// For example, the integer 5 is "101" in binary and its complement is "010" which is the integer 2.
// Given an integer n, return its complement.

public class ComplementInteger
{
    public class Solution 
    {
        public int BitwiseComplement(int n) 
        {
            if (n == 0)
            {
                return 1;
            }

            int mask = 1;

            while (mask < n)
            {
                mask = (mask << 1) | 1;
            }

            return mask ^ n;
        }
    }
}