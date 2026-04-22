namespace Graphs;

// 1722. Minimize Hamming Distance After Swap Operations
// You are given two integer arrays, source and target, both of length n. 
// You are also given an array allowedSwaps where each allowedSwaps[i] = [ai, bi] indicates 
// that you are allowed to swap the elements at index ai and index bi (0-indexed) of array source. 
// Note that you can swap elements at a specific pair of indices multiple times and in any order.
// The Hamming distance of two arrays of the same length, source and target, 
// is the number of positions where the elements are different. 
// Formally, it is the number of indices i for 0 <= i <= n-1 where source[i] != target[i] (0-indexed).
// Return the minimum Hamming distance of source and target after performing any amount of swap operations on array source.

public class MinimizeHammingDistanceAfterSwapOperations
{
    public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps) 
    {
        int n = source.Length;
        var graph = new Graph();

        foreach (var swap in allowedSwaps)
        {
            graph.AddEdge(swap[0], swap[1]);
        }

        int hammingDistance = 0;

        for (int i = 0; i < n; i++)
        {
            if (source[i] != target[i])
            {
                var componentNodes = graph.VisitNodes(i).ToList();
                var sourceValues = componentNodes.Select(node => source[node]).ToList();
                var targetValues = componentNodes.Select(node => target[node]).ToList();

                foreach (var value in sourceValues)
                {
                    if (targetValues.Contains(value))
                    {
                        targetValues.Remove(value);
                    }
                    else
                    {
                        hammingDistance++;
                    }
                }
            }
        }

        return hammingDistance;
        
    }

    public class Graph
    {
        private readonly Dictionary<int, List<int>> _adjacencyList = new();

        private readonly HashSet<int> _visited = new();

        public void AddEdge(int from, int to)
        {
            if (!_adjacencyList.ContainsKey(from))
                _adjacencyList[from] = new List<int>();
            if (!_adjacencyList.ContainsKey(to))
                _adjacencyList[to] = new List<int>();

            _adjacencyList[from].Add(to);
            _adjacencyList[to].Add(from);
        }

        public IEnumerable<int> GetNeighbors(int node)
        {
            return _adjacencyList.ContainsKey(node) ? _adjacencyList[node] : Enumerable.Empty<int>();
        }

        public IEnumerable<int> VisitNodes(int startNode)
        {
            var stack = new Stack<int>();
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                if (!_visited.Add(node))
                    continue;

                yield return node;

                foreach (var neighbor in GetNeighbors(node))
                {
                    if (!_visited.Contains(neighbor))
                        stack.Push(neighbor);
                }
            }
        }
    }
}