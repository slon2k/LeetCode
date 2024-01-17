namespace LeetCode.LeetCode150.Math;

public class FactorialTrailingZeroes
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            int count = 0;

            int five = 5;

            while (five <= n)
            {
                count += n / five;

                five *= 5;
            }

            return count;
        }
    }
}
