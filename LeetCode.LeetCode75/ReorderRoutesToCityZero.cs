namespace LeetCode.LeetCode75;

public class ReorderRoutesToCityZero
{
    public class Solution
    {
        public int MinReorder(int n, int[][] connections)
        {
            List<Connection>[] roads = new List<Connection>[n];
            int[] visited = new int[n];
            int[] previous = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                roads[i] = new List<Connection>();
            }

            for (int i = 0; i < connections.Length; i++)
            {
                int first = connections[i][0];
                int second = connections[i][1];

                var road = new Connection(first, second);
                
                roads[first].Add(road);
                roads[second].Add(road);
            }

            Stack<int> stack = new Stack<int>();

            stack.Push(0);

            while (stack.Count > 0)
            {
                int city = stack.Pop();

                if (visited[city] == 0)
                {
                    visited[city] = 1;

                    if (roads[city].Contains(new Connection(previous[city], city)))
                    {
                        count++;
                    }

                    foreach (var road in roads[city])
                    {
                        int next = road.First != city ? road.First : road.Second;

                        if (visited[next] == 0) 
                        {
                            previous[next] = city;

                            stack.Push(next);
                        }
                    }
                }
            }

            return count;
        }

        public record Connection(int First, int Second);
    }
}
