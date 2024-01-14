namespace LeetCode.LeetCode150.Graph;

internal class CloneGraph
{
    public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node is null)
            {
                return null;
            }

            Dictionary<int, Node> clones = new();

            HashSet<int> visited = new();

            Queue<Node> queue = new();

            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (!visited.Contains(current.val))
                {
                    visited.Add(current.val);

                    var clone = GetOrCreateClone(current, clones);

                    foreach (var neighbor in current.neighbors)
                    {
                        var neighborClone = GetOrCreateClone(neighbor, clones);

                        if (!clone.neighbors.Contains(neighborClone))
                        {
                            clone.neighbors.Add(neighborClone);
                        }

                        if (!visited.Contains(neighbor.val))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return clones[node.val];
        }

        private static Node GetOrCreateClone(Node node, Dictionary<int, Node> clones)
        {
            if (!clones.ContainsKey(node.val))
            {
                clones[node.val] = new(node.val);
            }

            return clones[node.val];
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
