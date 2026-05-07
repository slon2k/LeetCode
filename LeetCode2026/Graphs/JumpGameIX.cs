namespace LeetCode2026.Graphs;

// 3660. Jump Game IX
// You are given an integer array nums.
// From any index i, you can jump to another index j under the following rules:
// Jump to index j where j > i is allowed only if nums[j] < nums[i].
// Jump to index j where j < i is allowed only if nums[j] > nums[i].
// For each index i, find the maximum value in nums that can be reached by following any sequence of valid jumps starting at i.
// Return an array ans where ans[i] is the maximum value reachable starting from index i.

public class JumpGameIX
{
    public int[] MaxValue(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];

        if (n == 0)
        {
            return ans;
        }

        int[] suffixMin = new int[n];
        suffixMin[n - 1] = nums[n - 1];

        for (int i = n - 2; i >= 0; i--)
        {
            suffixMin[i] = Math.Min(nums[i], suffixMin[i + 1]);
        }

        int componentStart = 0;
        int componentMax = nums[0];

        for (int i = 0; i < n - 1; i++)
        {
            componentMax = Math.Max(componentMax, nums[i]);

            if (componentMax <= suffixMin[i + 1])
            {
                Fill(ans, componentStart, i, componentMax);
                componentStart = i + 1;
                componentMax = nums[componentStart];
            }
        }

        componentMax = Math.Max(componentMax, nums[n - 1]);
        Fill(ans, componentStart, n - 1, componentMax);

        return ans;
    }

    private static void Fill(int[] ans, int start, int end, int value)
    {
        for (int i = start; i <= end; i++)
        {
            ans[i] = value;
        }
    }
}