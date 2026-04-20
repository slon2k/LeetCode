namespace LeetCode2026.Arrays;

// 2078. Two Furthest Houses With Different Colors
// There are n houses in a row.
// You are given a 0-indexed integer array colors, where colors[i] is the color of the ith house.
// Return the maximum distance between two houses with different colors.
// The distance between the ith and jth houses is abs(i - j), where abs(x) is the absolute value of x.

public class TwoFurthestHousesWithDifferentColorsSolution
{
    public int MaxDistance(int[] colors)
    {
        int n = colors.Length;

        // Scan from right to find farthest index with different color from colors[0]
        int right = n - 1;
        while (colors[right] == colors[0]) right--;

        // Scan from left to find farthest index with different color from colors[n-1]
        int left = 0;
        while (colors[left] == colors[n - 1]) left++;

        return Math.Max(right, n - 1 - left);
    }
}