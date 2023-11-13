namespace LeetCode.LeetCode75;

public class NearestMazeExit
{
    public class Solution
    {
        private char[][] maze;
        private int[] entrance;

        public int NearestExit(char[][] maze, int[] entrance)
        {
            this.maze = maze;
            this.entrance = entrance;

            Queue<(int, int)> queue = new();

            Dictionary<(int x, int y), int> pathLengths = new();

            HashSet<(int x, int y)> visited = new();

            pathLengths[(entrance[0], entrance[1])] = 0;

            queue.Enqueue((entrance[0], entrance[1]));

            while (queue.Count > 0)
            {
                (int x, int y) = queue.Dequeue();
                
                visited.Add((x, y));

                if (IsExit(x, y))
                {
                    return pathLengths[(x, y)];
                }

                foreach (var item in Neighbors(x, y).Where(c => !visited.Contains(c)))
                {
                    pathLengths[(item.x, item.y)] = pathLengths[(x, y)] + 1;

                    queue.Enqueue(item);
                }
            }

            return -1;
        }

        private bool IsEdgeCell(int x, int y) => (x == 0 || y == 0 || x == maze.Length - 1 || y == maze[0].Length - 1);

        private bool IsExit(int x, int y) => IsEdgeCell(x, y) && (x != entrance[0] || y != entrance[1]);

        private List<(int x, int y)> Neighbors(int x, int y)
        {
            List<(int x, int y)> neighbors = new();

            if (x - 1 >= 0 && maze[x - 1][y] == '.')
            {
                neighbors.Add((x - 1, y));
            }

            if (y - 1 >= 0 && maze[x][y - 1] == '.')
            {
                neighbors.Add((x, y - 1));
            }

            if (x + 1 < maze.Length && maze[x + 1][y] == '.')
            {
                neighbors.Add((x + 1, y));
            }

            if (y + 1 < maze[0].Length && maze[x][y + 1] == '.')
            {
                neighbors.Add((x, y + 1));
            }

            return neighbors;
        }
    }
}
