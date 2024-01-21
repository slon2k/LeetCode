namespace LeetCode.LeetCode150.BitManipulation;

internal class NumberOf1Bits
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            string str = n.ToString("B");

            int count = 0;

            foreach (var digit in str)
            {
                if (digit == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
