namespace LeetCode.LeetCode75;

public class MinCostClimbingStairs
{
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int length = cost.Length;

            int[] minCost = new int[length];

            minCost[0] = cost[0];
            minCost[1] = cost[1];

            for (int i = 2; i < length; i++)
            {
                minCost[i] = Math.Min(minCost[i - 1], minCost[i - 2]) + cost[i];
            }

            return Math.Min(minCost[length - 1], minCost[length - 2]);
        }
    }
}
