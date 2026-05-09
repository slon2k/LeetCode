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

        int maxValue = 0;
        var primeValues = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (nums[i] > maxValue)
            {
                maxValue = nums[i];
            }

            if (IsPrime(nums[i]))
            {
                primeValues.Add(nums[i]);
            }
        }

        var indicesByPrime = BuildIndicesByPrimeFactor(nums, primeValues, maxValue);

        var visited = new HashSet<int>();
        var queue = new Queue<(int index, int jumps)>();
        var usedPrimeTeleport = new HashSet<int>();
        queue.Enqueue((0, 0));
        visited.Add(0);

        while (queue.Count > 0)
        {
            var (index, jumps) = queue.Dequeue();
            if (index == n - 1)
            {
                return jumps;
            }

            // Adjacent steps
            if (index > 0)
            {
                int left = index - 1;
                if (!visited.Contains(left))
                {
                    if (left == n - 1)
                    {
                        return jumps + 1;
                    }

                    visited.Add(left);
                    queue.Enqueue((left, jumps + 1));
                }
            }

            if (index < n - 1)
            {
                int right = index + 1;
                if (!visited.Contains(right))
                {
                    if (right == n - 1)
                    {
                        return jumps + 1;
                    }

                    visited.Add(right);
                    queue.Enqueue((right, jumps + 1));
                }
            }

            // Prime teleportation
            int currentValue = nums[index];
            if (primeValues.Contains(currentValue) && usedPrimeTeleport.Add(currentValue))
            {
                if (indicesByPrime.TryGetValue(currentValue, out var teleportTargets))
                {
                    foreach (int neighbor in teleportTargets)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            if (neighbor == n - 1)
                            {
                                return jumps + 1;
                            }

                            visited.Add(neighbor);
                            queue.Enqueue((neighbor, jumps + 1));
                        }
                    }
                }
            }
        }

        return -1; // If we cannot reach the end
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    private static Dictionary<int, List<int>> BuildIndicesByPrimeFactor(int[] nums, HashSet<int> primeValues, int maxValue)
    {
        var result = new Dictionary<int, List<int>>();
        if (primeValues.Count == 0 || maxValue < 2)
        {
            return result;
        }

        int[] smallestPrimeFactor = BuildSmallestPrimeFactor(maxValue);

        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];
            if (value < 2)
            {
                continue;
            }

            int remaining = value;
            while (remaining > 1)
            {
                int prime = smallestPrimeFactor[remaining];
                if (prime == 0)
                {
                    prime = remaining;
                }

                if (primeValues.Contains(prime))
                {
                    if (!result.TryGetValue(prime, out var list))
                    {
                        list = [];
                        result[prime] = list;
                    }

                    list.Add(i);
                }

                while (remaining % prime == 0)
                {
                    remaining /= prime;
                }
            }
        }

        return result;
    }

    private static int[] BuildSmallestPrimeFactor(int maxValue)
    {
        int[] spf = new int[maxValue + 1];

        for (int i = 2; i <= maxValue; i++)
        {
            if (spf[i] != 0)
            {
                continue;
            }

            spf[i] = i;

            if ((long)i * i > maxValue)
            {
                continue;
            }

            for (int j = i * i; j <= maxValue; j += i)
            {
                if (spf[j] == 0)
                {
                    spf[j] = i;
                }
            }
        }

        return spf;
    }
}