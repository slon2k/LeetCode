
namespace LeetCode.LeetCode150.Graph;

public class EvaluateDivision
{
    public class Solution
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            Dictionary<string, HashSet<string>> neighbors = new();

            Dictionary<(string, string), double> results = new();
            
            for (int i = 0; i < equations.Count; i++)
            {
                var equation = equations[i];
                var (first, second, value) = (equation[0], equation[1], values[i]);

                AddResults(results, first, second, value);

                AddNeighbors(first, second, neighbors);
            }

            var answer = new List<double>();

            foreach (var query in queries) 
            {
                answer.Add(Find(query[0], query[1], results, neighbors));
            }

            return answer.ToArray();
        }

        private double Find(string begin, string end, Dictionary<(string, string), double> results, Dictionary<string, HashSet<string>> neighbors)
        {
            if (results.ContainsKey((begin, end)))
            {
                return results[(begin, end)];
            }

            if (!neighbors.ContainsKey(begin) || !neighbors.ContainsKey(end))
            {
                return -1.0;
            }

            HashSet<string> visited = new();

            Stack<(string, double)> stack = new();

            stack.Push((begin, 1.0));

            while (stack.Count > 0)
            {
                var (node, value) = stack.Pop();

                if (node == end)
                {
                    return value;
                }

                if (!visited.Contains(node))
                {
                    visited.Add(node);

                    foreach (string neighbor in GetNeighbors(neighbors, node))
                    {
                        if (!visited.Contains(neighbor))
                        {
                            stack.Push((neighbor, value * results[(node, neighbor)]));
                        }
                    }
                }
            }

            return -1.0;
        }

        private IEnumerable<string> GetNeighbors(Dictionary<string, HashSet<string>> neighbors, string node) => neighbors.ContainsKey(node) ? neighbors[node] : Enumerable.Empty<string>();

        private static void AddResults(Dictionary<(string, string), double> results, string first, string second, double value)
        {
            results[(first, second)] = value;
            results[(second, first)] = 1.0 / value;
            results[(first, first)] = 1.0;
            results[(second, second )] = 1.0;
        }

        private static void AddNeighbors(string first, string second, Dictionary<string, HashSet<string>> neighbors)
        {
            if (!neighbors.ContainsKey(first))
            {
                neighbors[first] = new();
            };

            if (!neighbors.ContainsKey(second))
            {
                neighbors[second] = new();
            };

            neighbors[second].Add(first);
            neighbors[first].Add(second);
        }
    }
}