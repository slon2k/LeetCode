namespace LeetCode.LeetCode150.BitManipulation;

public class NumbersRangeBitwiseAnd
{
    public class Solution
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            int mask = 1 << 30;

            int result = 0;

            while (mask > 0)
            {
                if ((left & mask) != (right & mask))
                {
                    break;
                }

                result |= left & mask;

                mask >>= 1;
            }

            return result;
        }
    }
}
