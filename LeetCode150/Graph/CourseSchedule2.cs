namespace LeetCode.LeetCode150.Graph;

internal class CourseSchedule2
{
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var graph = new Graph();

            graph.AddNodes(Enumerable.Range(0, numCourses));

            foreach (var prerequisite in prerequisites)
            {
                var (begin, end) = (prerequisite[1], prerequisite[0]);
                
                if (begin == end)
                {
                    return Array.Empty<int>();
                }

                graph.AddEdge(begin, end);
            }

            List<int> result = new();

            while (graph.NodesWithoutIncoming.Count > 0)
            {
                var node = graph.NodesWithoutIncoming.First();

                result.Add(node);

                graph.RemoveNode(node);
            }

            if (graph.IsEmpty)
            {
                return result.ToArray();
            }

            return Array.Empty<int>();
        }

        public class Graph
        {
            private HashSet<int> nodes = new();

            private Dictionary<int, HashSet<int>> edges = new();

            private HashSet<int> nodesWithoutIncoming = new();

            private Dictionary<int, int> incoming = new();

            public bool IsEmpty => nodes.Count == 0;

            public List<int> NodesWithoutIncoming => nodesWithoutIncoming.ToList();

            public void AddNode(int node)
            {
                nodes.Add(node);

                if (!incoming.ContainsKey(node))
                {
                    incoming[node] = 0;
                }

                if (!edges.ContainsKey(node))
                {
                    edges.Add(node, new HashSet<int>());
                }

                if (incoming[node] == 0)
                {
                    nodesWithoutIncoming.Add(node);
                }
            }

            public void AddNodes(IEnumerable<int> nodes)
            {
                foreach (int node in nodes)
                {
                    AddNode(node);
                }
            }

            public void AddEdge(int begin, int end)
            {
                AddNode(begin);
                AddNode(end);

                edges[begin].Add(end);

                incoming[end]++;

                nodesWithoutIncoming.Remove(end);
            }

            public void RemoveNode(int node)
            {
                if (incoming[node] > 0)
                {
                    throw new InvalidOperationException("Node has incoming edges");
                }

                incoming.Remove(node);
                nodesWithoutIncoming.Remove(node);
                nodes.Remove(node);

                if (!edges.ContainsKey(node))
                {
                    return;
                }

                foreach (var end in edges[node])
                {
                    incoming[end]--;

                    if (incoming[end] == 0)
                    {
                        nodesWithoutIncoming.Add(end);
                    }
                }

                edges.Remove(node);
            }
        }
    }
}
