namespace LeetCode2026.Graphs;

// 3629. Minimum Jumps to Reach End via Prime Teleportation
// You are given an integer array nums of length n.
// You start at index 0, and your goal is to reach index n - 1.
// From any index i, you may perform one of the following operations:
// Adjacent Step: Jump to index i + 1 or i - 1, if the index is within bounds.
// Prime Teleportation: If nums[i] is a prime number p, you may instantly jump to any index j != i such that nums[j] % p == 0.
// Return the minimum number of jumps required to reach index n - 1.

public class MinimumJumpsToReachEndViaPrimeTeleportation
{
    public int MinJumps(int[] nums)
    {
        int n = nums.Length;
        if (n == 1)
        {
            return 0;
        }

        var graph = PopulateGraph(nums);

        var visited = new HashSet<int>();
        var queue = new Queue<(int index, int jumps)>();
        queue.Enqueue((0, 0));
        visited.Add(0);

        while (queue.Count > 0)
        {
            var (index, jumps) = queue.Dequeue();
            if (index == n - 1)
            {
                return jumps;
            }

            foreach (var neighbor in graph[index])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue((neighbor, jumps + 1));
                }
            }
        }

        return -1; // If we cannot reach the end
    }

    private static Dictionary<int, List<int>> PopulateGraph(int[] nums)
    {
        int n = nums.Length;
        var graph = new Dictionary<int, List<int>>();
        var positions = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++)
        {
            graph[i] = [];

            if (i > 0)
            {
                graph[i].Add(i - 1);
            }
            if (i < n - 1)
            {
                graph[i].Add(i + 1);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!positions.ContainsKey(nums[i]))
            {
                positions[nums[i]] = [];
            }
            positions[nums[i]].Add(i);
        }

        foreach (var kvp in positions)
        {
            int num = kvp.Key;
            if (IsPrime(num))
            {
                var divisiblePositions = new List<int>();
                foreach (var otherKvp in positions)
                {
                    if (otherKvp.Key % num == 0)
                    {
                        divisiblePositions.AddRange(otherKvp.Value);
                    }
                }

                foreach (int index in kvp.Value)
                {
                    foreach (int otherIndex in divisiblePositions)
                    {
                        if (index != otherIndex)
                        {
                            graph[index].Add(otherIndex);
                        }
                    }
                }
            }
        }
        return graph;
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}