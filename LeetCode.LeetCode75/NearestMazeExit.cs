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

            Queue<(int x, int y, int step)> queue = new();

            int height = maze.Length;
            int width = maze[0].Length;

            int[,] visited = new int[height, width];

            queue.Enqueue((entrance[0], entrance[1], 0));

            while (queue.Count > 0)
            {
                (int x, int y, int step) = queue.Dequeue();

                if (visited[x, y] == 0) 
                { 
                    visited[x, y] = 1;

                    if (IsExit(x, y))
                    {
                        return step;
                    }

                    foreach (var item in Neighbors(x, y).Where(c => visited[c.x, c.y] == 0))
                    {
                        queue.Enqueue((item.x, item.y, step + 1));
                    }
                }
            }

            return -1;
        }

        private bool IsEdgeCell(int x, int y) => (x == 0 || y == 0 || x == maze.Length - 1 || y == maze[0].Length - 1);

        private bool IsExit(int x, int y) => IsEdgeCell(x, y) && (x != entrance[0] || y != entrance[1]);

        private char GetCell(int x, int y)
        {
            if (x >= 0 && y >=0 && x < maze.Length && y < maze[0].Length)
            {
                return maze[x][y];
            }

            return '#';
        }

        private List<(int x, int y)> Neighbors(int x, int y)
        {
            List<(int x, int y)> neighbors = new()
            {
                (x - 1, y),
                (x, y - 1),
                (x + 1, y),
                (x, y + 1)
            };

            return neighbors.Where(c => GetCell(c.x, c.y) == '.').ToList();
        }
    }
}
