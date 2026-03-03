// 18. 4Sum
// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
// 0 <= a, b, c, d < n
// a, b, c, and d are distinct.
// nums[a] + nums[b] + nums[c] + nums[d] == target
// You may return the answer in any order.

namespace LeetCode2026.TwoPointers;

public class FourSum
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = new HashSet<(int, int, int, int)>();
            int n = nums.Length;
            long targetLong = target; // To prevent overflow when adding four integers
            for (int i = 1; i <= n - 3; i++)
            {
                for (int j = i + 1; j <= n - 2; j++)
                {
                    int left = 0;
                    int right = n - 1;

                    while (left < i && right > j)
                    {
                        long sum = (long)nums[left] + (long)nums[i] + (long)nums[j] + (long)nums[right];

                        if (sum == targetLong)
                        {
                            result.Add((nums[left], nums[i], nums[j], nums[right]));
                            left++;
                            right--;
                        }
                        else if (sum < targetLong)
                            left++;
                        else
                            right--;
                    }
                }

            }
            return [.. result.Select(quad => (IList<int>)[quad.Item1, quad.Item2, quad.Item3, quad.Item4])];
        }
    }
}
