namespace LeetCode2026.Arrays;

// 3741. Minimum Distance Between Three Equal Elements II
// You are given an integer array nums.
// A tuple (i, j, k) of 3 distinct indices is good if nums[i] == nums[j] == nums[k].
// The distance of a good tuple is abs(i - j) + abs(j - k) + abs(k - i), where abs(x) denotes the absolute value of x.
// Return an integer denoting the minimum possible distance of a good tuple. If no good tuples exist, return -1.

public class MinimumDistanceBetweenThreeEqualElementsIISolution 
{
    public int MinimumDistance(int[] nums) {
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
            if (indices.Count >= 3) 
            {
                for (int i = 0; i < indices.Count - 2; i++)
                {
                    minDistance = Math.Min(minDistance, CalculateDistance(indices[i], indices[i + 1], indices[i + 2]));
                }
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }

    private static int CalculateDistance(int i, int j, int k)
    {
        return (Math.Max(i, Math.Max(j, k)) - Math.Min(i, Math.Min(j, k))) * 2;
    }
}