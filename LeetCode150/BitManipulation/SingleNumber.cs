namespace LeetCode.LeetCode150.BitManipulation;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            int mask = 1 << i;

            int count = 0;

            foreach (int x in nums)
            {
                count += (mask & x) != 0 ? 1 : 0;
            }

            if (count % 3 != 0)
            {
                result |= mask;
            }
        }

        return result;
    }
}