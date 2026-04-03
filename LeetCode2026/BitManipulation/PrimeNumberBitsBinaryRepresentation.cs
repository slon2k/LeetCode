namespace LeetCode2026.BitManipulation;

// 762. Prime Number of Set Bits in Binary Representation
// Given two integers left and right, return the count of numbers in the inclusive range [left, right] having a prime number of set bits in their binary representation.
public class PrimeNumberBitsBinaryRepresentation
{
    public class Solution
    {
        private static readonly HashSet<int> primeSet = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];

        public int CountPrimeSetBits(int left, int right)
        {
            int count = 0;
            
            for (int num = left; num <= right; num++)
            {
                int setBits = CountSetBits(num);
                if (primeSet.Contains(setBits))
                {
                    count++;
                }
            }
            return count;
        }

        private int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1; // Increment count if the least significant bit is set
                n >>= 1; // Right shift to check the next bit
            }
            return count;
        }
    }
}