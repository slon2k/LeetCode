namespace LeetCode.LeetCode150.DP;

internal class ClimbingStairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int result1 = 1;
            int result2 = 1;

            int result = 1;

            for (int i = 2; i <= n; i++)
            {
                result = result1 + result2;

                (result2, result1) = (result, result2);
            }

            return result;
        }
    }
}
