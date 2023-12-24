namespace LeetCode.LeetCode150.Intervals;

public class SummaryRanges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();

            if (nums.Length == 0)
            {
                return result;
            }

            int start = nums[0];
            int current = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    result.Add(IntervalToString(start, nums[i - 1]));
                    start = nums[i];
                }

                current = nums[i];
            }

            result.Add(IntervalToString(start, current));


            return result;
        }

        private static string IntervalToString(int a, int b) => a == b ? a.ToString() : $"{a}->{b}";
    }
}
