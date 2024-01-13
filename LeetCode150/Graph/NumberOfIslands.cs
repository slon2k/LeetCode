namespace LeetCode.LeetCode150.Graph;

public class NumberOfIslands
{
    public class Solution
    {
        private int[,] visited;
        private char[][] grid;
        private int height;
        private int width;

        public int NumIslands(char[][] grid)
        {
            width = grid[0].Length;
            height = grid.Length;
            this.grid = grid;
            visited = new int[height, width];

            int island = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (visited[i, j] == 0 && grid[i][j] == '1')
                    {
                        Traverse(i, j, ++island);
                    }
                }
            }

            return island;
        }

        private void Traverse(int x, int y, int island)
        {
            Stack<(int, int)> stack = new();

            stack.Push((x, y));

            while (stack.Count > 0)
            {
                var (i, j) = stack.Pop();

                if (visited[i, j] == 0)
                {
                    visited[i, j] = island;
                }

                foreach (var (a, b) in GetNeighbors(i, j))
                {
                    if (grid[a][b] == '1' && visited[a, b] == 0)
                    {
                        stack.Push((a, b));
                    }
                }
            }
        }

        private IEnumerable<(int, int)> GetNeighbors(int x, int y)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i != 0 && j != 0)
                    {
                        continue;
                    }

                    int a = x + i;
                    int b = y + j;

                    if (a >=0 && a < height && b >= 0 && b < width)
                    {
                        yield return (a, b);
                    }

                }
            }
        }
    }
}
