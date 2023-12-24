namespace LeetCode.LeetCode150.Intervals;

public class MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0) 
            {
                return Array.Empty<int[]>();
            }

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<Interval> result = new()
            {
                ToInterval(intervals[0])
            };

            for (int i = 1; i < intervals.Length; i++)
            {
                var current = ToInterval(intervals[i]);

                var previous = result[^1];

                if (current.Start <= previous.End)
                {
                    result[^1] = new (previous.Start, Math.Max(previous.End, current.End));
                } else
                {
                    result.Add(current);
                }
            }

            return result.Select(ToArray).ToArray();
        }

        private record struct Interval(int Start, int End);

        private static Interval ToInterval(int[] array) => new(array[0], array[1]);

        private static int[] ToArray(Interval interval) => new int[] { interval.Start, interval.End };
    }
}
