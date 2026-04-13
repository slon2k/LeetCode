namespace LeetCode2026.Arrays;

// 1848. Minimum Distance to the Target Element
// Given an integer array nums (0-indexed) and two integers target and start, find an index i such that nums[i] == target and abs(i - start) is minimized. Note that abs(x) is the absolute value of x.
// Return abs(i - start).

public class MinimumDistanceToTargetElementSolution
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        int minDistance = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                int distance = Math.Abs(i - start);
                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }
        }
        return minDistance;
    }
}