namespace LeetCode2026.DynamicProgramming;

// 2770. Maximum Number of Jumps to Reach the Last Index
// You are given a 0-indexed integer array nums of length n and an integer target.
// A jump from index i to index j (where i < j) is valid if the following conditions are satisfied:
// 0 <= i < j < n
// -target <= nums[j] - nums[i] <= target
// Return the maximum number of jumps you can make to reach the last index of nums. 
// If there is no way to reach the last index, return -1.

public class MaximumNumberJumpsToReachLastIndex
{
    public int MaximumJumps(int[] nums, int target)
    {
        int n = nums.Length;
        var dp = new int[n];
        Array.Fill(dp, -1);
        dp[0] = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dp[j] != -1 && Math.Abs(nums[i] - nums[j]) <= target)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        return dp[n - 1];
    }
}