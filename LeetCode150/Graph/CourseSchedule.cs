
namespace LeetCode.LeetCode150.Graph;

public class CourseSchedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = new Graph();

            graph.AddNodes(Enumerable.Range(0, numCourses));

            foreach (var item in prerequisites) 
            {
                graph.AddEdge(item[0], item[1]);
            }

            while (graph.NodesWithNoIncoming.Count > 0)
            {
                graph.RemoveVertex(graph.NodesWithNoIncoming.First());
            }

            return graph.IsEmpty;
        }

        public class Graph
        {
            public readonly Dictionary<int, List<int>> Edges = new();

            public bool IsEmpty => nodes.Count == 0;

            private readonly Dictionary<int, int> incoming = new();

            private readonly HashSet<int> starting = new();

            private HashSet<int> nodes = new();

            public List<int> Nodes => nodes.ToList();

            public List<int> NodesWithNoIncoming => starting.ToList();

            public void AddEdge(int from, int to)
            {
                AddVertex(from);
                AddVertex(to);

                Edges[from].Add(to);
                starting.Remove(to);
                incoming[to]++;
            }

            public void AddNodes(IEnumerable<int> nodes)
            {
                foreach (int node in nodes)
                {
                    AddVertex(node);
                }
            }

            public void AddVertex(int vertex)
            {
                nodes.Add(vertex);

                if (!incoming.ContainsKey(vertex))
                {
                    incoming[vertex] = 0;
                }

                if (incoming[vertex] == 0)
                {
                    starting.Add(vertex);
                }

                if (!Edges.ContainsKey(vertex))
                {
                    Edges[vertex] = new();
                }
            }

            public void RemoveVertex(int from)
            {
                if (incoming.ContainsKey(from) && incoming[from] > 0)
                {
                    throw new InvalidOperationException("Vertex has incoming edges");
                }

                nodes.Remove(from);
                starting.Remove(from);

                if (!Edges.ContainsKey(from))
                { 
                    return;
                }

                foreach (var end in Edges[from])
                {
                    incoming[end]--;

                    if (incoming[end] == 0)
                    {
                        starting.Add(end);
                    }
                }

                Edges.Remove(from);
            }
        }
    }
}
