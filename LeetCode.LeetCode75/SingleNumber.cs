namespace LeetCode.LeetCode75;

public class SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (var item in nums)
            {
                result ^= item;                
            }

            return result;
        }
    }
}
