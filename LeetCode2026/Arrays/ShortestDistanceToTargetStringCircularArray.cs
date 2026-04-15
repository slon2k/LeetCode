namespace LeetCode2026.Arrays;

// 2515. Shortest Distance to Target String in a Circular Array
// You are given a 0-indexed circular array words that contains distinct strings, and a string target that is present in words. You can start at index start of the circular array and you want to reach the index of the target string.
// In one step, you can move from index i to index:
// (i + 1) % words.length, or   (i - 1 + words.length) % words.length
// Return the shortest distance needed to reach the target string.

public class ShortestDistanceToTargetStringCircularArraySolution
{
    public int ClosestTarget(string[] words, string target, int start)
    {
        int n = words.Length;
        
        for (int i = 0; i < n; i++)
        {
            if (words[(start + i) % n] == target || words[(start - i + n) % n] == target)
            {
                return i;
            }
        }
        return -1;
    }
}