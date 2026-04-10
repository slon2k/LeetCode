namespace LeetCode2026.Arrays;

// 3740. Minimum Distance Between Three Equal Elements I
// You are given an integer array nums.
// A tuple (i, j, k) of 3 distinct indices is good if nums[i] == nums[j] == nums[k].
// The distance of a good tuple is abs(i - j) + abs(j - k) + abs(k - i), where abs(x) denotes the absolute value of x.
// Return an integer denoting the minimum possible distance of a good tuple. If no good tuples exist, return -1.

public class MinimumDistanceBetweenThreeEqualElementsISolution 
{
    public int MinDistance(int[] nums) {
        var indicesMap = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (!indicesMap.ContainsKey(nums[i])) 
            {
                indicesMap[nums[i]] = new List<int>();
            }
            indicesMap[nums[i]].Add(i);
        }

        int minDistance = int.MaxValue;
        foreach (var kvp in indicesMap) {
            var indices = kvp.Value;
            if (indices.Count >= 3) {
                for (int i = 0; i < indices.Count - 2; i++)
                {
                    for (int j = i + 1; j < indices.Count - 1; j++)
                    {
                        for (int k = j + 1; k < indices.Count; k++)
                        {
                            int distance = Math.Abs(indices[i] - indices[j]) + Math.Abs(indices[j] - indices[k]) + Math.Abs(indices[k] - indices[i]);
                            minDistance = Math.Min(minDistance, distance);
                        }
                    }

                }
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}