namespace LeetCode2026.BitManipulation;

// 78. Subsets
// Given an integer array nums of unique elements, return all possible subsets (the power set).
// The solution set must not contain duplicate subsets. The subsets can be returned in any order.

public class Subsets
{
    public class Solution 
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            int n = nums.Length;

            for (int i = 0; i < (1 << n); i++)
            {
                var subset = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        subset.Add(nums[j]);
                    }
                }

                result.Add(subset);
            }

            return result;
        }
    }
}