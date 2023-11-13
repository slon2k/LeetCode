namespace LeetCode.LeetCode75;

public class RottingOranges
{
    public class Solution
    {
        private int[][] grid;

        public int OrangesRotting(int[][] grid)
        {
            this.grid = grid;

            Queue<(int x, int y)> queue = new();

            Dictionary<(int x, int y), int> level = new();

            HashSet<(int x, int y)> visited = new();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j));
                        level[(i, j)] = 0;
                    }
                }
            }

            if (!GetCells().Any(c => GetCell(c) == 1))
            {
                return 0;
            }

            while (queue.Count > 0)
            {
                (int x, int y) = queue.Dequeue();

                if (!visited.Contains((x, y)))
                {
                    visited.Add((x, y));

                    grid[x][y] = 2;

                    foreach (var item in FreshNeighbors(x, y))
                    {
                        if (!level.ContainsKey(item))
                        {
                            level[item] = level[(x, y)] + 1;
                            queue.Enqueue(item);
                        }
                    }
                }
            }

            if (GetCells().Any(c => GetCell(c) == 1))
            {
                return -1;
            }

            if (level.Count == 0)
            {
                return -1;
            }

            return level.Select(x => x.Value).Distinct().Max();
        }

        private List<(int x, int y)> FreshNeighbors(int x, int y)
        {
            List<(int x, int y)> neighbors = new()
            {
                (x - 1, y),
                (x, y - 1),
                (x + 1, y),
                (x, y + 1)
            };

            return neighbors.Where(c => GetCell(c) == 1).ToList();
        }

        private int GetCell((int x, int y) cell)
        {
            if (cell.x >= 0 && cell.x < grid.Length && cell.y >= 0 && cell.y < grid[0].Length )
            {
                return grid[cell.x][cell.y];
            }

            return -1;
        }

        private IEnumerable<(int x, int y)> GetCells()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    yield return (i, j);
                }
            }
        }
    }
}
