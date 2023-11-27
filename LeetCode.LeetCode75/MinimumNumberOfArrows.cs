namespace LeetCode.LeetCode75;

public class MinimumNumberOfArrows
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));

            if (points.Length == 0)
            {
                return 0;
            }

            var current = points[0];

            int count = 1;

            for (int i = 1; i < points.Length; i++)
            {
                var balloon = points[i];

                if (balloon[0] > current[1])
                {
                    count++;
                    current = balloon;
                }
            }

            return count;
        }
    }
}
