namespace LeetCode.LeetCode75;

public class EvaluateDivision
{
    public class Solution
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            Dictionary<(string, string), double> calculatedValues = new();

            Dictionary<string, HashSet<string>> connections = new();

            for (int i = 0; i < equations.Count; i++)
            {
                string first = equations[i][0];
                string second = equations[i][1];
                double value = values[i];

                AddValues(calculatedValues, connections, first, second, value);
            }

            List<double> results = new();

            foreach (var item in queries)
            {
                List<string> path = FindPath(item[0], item[1], calculatedValues, connections);

                results.Add(Calculate(path, calculatedValues));
            }

            return results.ToArray();
        }

        private double Calculate(List<string> path, Dictionary<(string, string), double> calculatedValues)
        {
            if (path.Count == 0)
            {
                return -1.0;
            };

            if (path.Count == 1)
            {
                if (calculatedValues.ContainsKey((path[0], path[0])))
                {
                    return 1.0;
                }

                return -1;
            }

            double result = 1;

            for (int i = 1; i < path.Count; i++)
            {
                result *= calculatedValues[(path[i - 1], path[i])];
            }

            return result;
        }

        private List<string> FindPath(string v1, string v2, Dictionary<(string, string), double> calculatedValues, Dictionary<string, HashSet<string>> connections)
        {
            if (calculatedValues.ContainsKey((v1, v2)))
            {
                return new List<string>() { v1, v2 };
            }

            HashSet<string> visited = new();

            Dictionary<string, List<string>> paths = new();

            paths[v1] = new List<string>() { v1 };

            Stack<string> stack = new();

            stack.Push(v1);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                visited.Add(current);

                if (current == v2)
                {
                    return paths[current];
                }

                if (connections.ContainsKey(current))
                {
                    foreach (var connection in connections[current].Where(c => !visited.Contains(c)))
                    {
                        paths[connection] = new List<string>(paths[current]) { connection };

                        stack.Push(connection);
                    }
                }
            }

            return new List<string>();
        }

        private static void AddValues(Dictionary<(string, string), double> calculatedValues, Dictionary<string, HashSet<string>> connections, string first, string second, double value)
        {
            calculatedValues[(first, second)] = value;
            calculatedValues[(first, first)] = 1;
            calculatedValues[(second, second)] = 1;
            calculatedValues[(second, first)] = 1 / value;

            if (connections.ContainsKey(first))
            {
                connections[first].Add(second);
            }
            else
            {
                connections[first] = new HashSet<string>
                {
                    second
                };
            }

            if (connections.ContainsKey(second))
            {
                connections[second].Add(first);
            }
            else
            {
                connections[second] = new HashSet<string>
                {
                    first
                };
            }
        }
    }
}
