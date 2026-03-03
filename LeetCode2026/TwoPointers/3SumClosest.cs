namespace LeetCode2026.TwoPointers;

// 16. 3Sum Closest
// Given an integer array nums of length n and an integer target, find three integers at distinct indices in nums such that the sum is closest to target.
// Return the sum of the three integers.
// You may assume that each input would have exactly one solution.
public class SolutionThreeSumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length < 3)
            throw new ArgumentException("Input array must have at least three elements.");
        
        Array.Sort(nums);

        int result = nums[0] + nums[1] + nums[2];

        for (int i = 1; i < nums.Length - 1; i++)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < i && right > i)
            {
                int sum = nums[left] + nums[i] + nums[right];

                if (Math.Abs(sum - target) < Math.Abs(result - target))
                    result = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }   
        }

        return result;
    }
}