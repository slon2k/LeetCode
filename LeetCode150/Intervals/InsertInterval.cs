namespace LeetCode.LeetCode150.Intervals;

public class InsertInterval
{
    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals.Length == 0)
            {
                return new int[][] { newInterval };
            }

            List<Interval> intervalList = new();

            var first = new Interval(intervals[0][0], intervals[0][1]);

            var interval = new Interval(newInterval[0], newInterval[1]);

            if (interval.End < first.Start) 
            {
                intervalList.Add(interval);
            }

            first = HaveIntersection(first, interval) ? Merge(first, interval) : first;

            intervalList.Add(first);

            for (int i = 1; i < intervals.Length; i++)
            {
                var previous = intervalList[^1];
                var current = new Interval(intervals[i][0], intervals[i][1]);

                current = HaveIntersection(current, interval) ? Merge(current, interval) : current;

                if (HaveIntersection(previous, current))
                {
                    intervalList[^1] = Merge(current, previous);
                } else
                {
                    if (interval.Start > previous.End && interval.End < current.Start)
                    {
                        intervalList.Add(interval);
                    }

                    intervalList.Add(current);
                }
            }

            if (interval.Start > intervalList[^1].End)
            {
                intervalList.Add(interval);
            }

            return intervalList.Select(x => new int[] { x.Start, x.End }).ToArray();
        }

        private record struct Interval(int Start, int End);

        private bool HaveIntersection(Interval interval1, Interval interval2) => (interval1.Start >= interval2.Start && interval1.Start <= interval2.End) 
            || (interval2.Start >= interval1.Start && interval2.Start <= interval1.End);

        private Interval Merge(Interval interval1, Interval interval2) => new Interval(Math.Min(interval1.Start, interval2.Start), Math.Max(interval1.End, interval2.End));
    }
}
