namespace LeetCode.LeetCode75;

public class NonOverlappingIntervals
{
    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[1] - y[1]);

            int count = 0;

            if (intervals.Length == 0)
            {
                return 0;
            }

            var current = intervals[0];

            for (int i = 1; i < intervals.Length; i++)
            {
                var interval = intervals[i];

                if (interval[0] < current[1])
                {
                    count ++;
                } else
                {
                    current = interval;
                }
            }

            return count;
        }
    }
}
