namespace LeetCode2026.Arrays;

// 1674. Minimum Moves to Make Array Complementary
// You are given an integer array nums of even length n and an integer limit. 
// In one move, you can replace any integer from nums with another integer between 1 and limit, inclusive.
// The array nums is complementary if for all indices i (0-indexed), nums[i] + nums[n - 1 - i] equals the same number. 
// For example, the array [1,2,3,4] is complementary because for all indices i, nums[i] + nums[n - 1 - i] = 5.
// Return the minimum number of moves required to make nums complementary.

public class MinimumMovesToMakeArrayComplementary
{
    public int MinMoves(int[] nums, int limit)
    {
        var n = nums.Length;
        var diff = new int[(2 * limit) + 2];

        for (int i = 0; i < n / 2; i++)
        {
            var left = nums[i];
            var right = nums[n - 1 - i];

            var min = Math.Min(left, right);
            var max = Math.Max(left, right);
            var sum = left + right;

            // Default is 2 moves for each sum in [2, 2 * limit].
            diff[2] += 2;
            diff[(2 * limit) + 1] -= 2;

            // 1 move for sums in [min + 1, max + limit].
            diff[min + 1] -= 1;
            diff[max + limit + 1] += 1;

            // 0 moves for exact current pair sum.
            diff[sum] -= 1;
            diff[sum + 1] += 1;
        }

        var result = int.MaxValue;
        var currentMoves = 0;

        for (int target = 2; target <= 2 * limit; target++)
        {
            currentMoves += diff[target];
            result = Math.Min(result, currentMoves);
        }

        return result;
    }
}
