using System.Xml;

namespace LeetCode2026.Graphs;

// 1345. Jump Game IV
// Given an array of integers arr, you are initially positioned at the first index of the array.
// In one step you can jump from index i to index:
//     i + 1 where: i + 1 < arr.length.
//     i - 1 where: i - 1 >= 0.
//     j where: arr[i] == arr[j] and i != j.
// Return the minimum number of steps to reach the last index of the array.
// Notice that you can not jump outside of the array at any time.

public class JumpGameIV
{
    public int MinJumps(int[] arr) 
    {
        var visited = new HashSet<int>();
        var target = arr.Length - 1;
        var queue = new Queue<(int node, int steps)>();

        Dictionary<int, List<int>> valueToIndices = [];

        for (int i = 0; i < arr.Length; i++)
        {
            var value = arr[i];
            if (!valueToIndices.ContainsKey(value))
            {
                valueToIndices[value] = [];
            }
            valueToIndices[value].Add(i);
        }

        queue.Enqueue((0, 0));
        visited.Add(0);

        while (queue.Count > 0)
        {
            var (node, steps) = queue.Dequeue();
            if (node == target)
            {
                return steps;
            }

            if (node + 1 < arr.Length && !visited.Contains(node + 1))
            {
                queue.Enqueue((node + 1, steps + 1));
                visited.Add(node + 1);
            }

            if (node - 1 >= 0 && !visited.Contains(node - 1))
            {
                queue.Enqueue((node - 1, steps + 1));
                visited.Add(node - 1);
            }

            if (valueToIndices.ContainsKey(arr[node]))
            {
                foreach (var next in valueToIndices[arr[node]])
                {
                    if (next != node && !visited.Contains(next))
                    {
                        queue.Enqueue((next, steps + 1));
                        visited.Add(next);
                    }
                }
                valueToIndices.Remove(arr[node]);
            }
        }

        return -1;
    }
}