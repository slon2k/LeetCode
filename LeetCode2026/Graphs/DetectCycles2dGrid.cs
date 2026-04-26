namespace LeetCode2026.Graphs;

// 1559. Detect Cycles in 2D Grid
// Given a 2D array of characters grid of size m x n, you should find
// if there is a cycle in the grid. A cycle is a path of length 4 or more in the grid that starts and ends at the same cell.
// From a given cell, you can move to one of the next four cells: up, down, left, or right, provided the next cell has the same character value as the current cell.
// Also, you cannot move to the previous cell in the path. The path should be made of the same character value cells.
// Return true if there is a cycle in grid, or false otherwise. 

public class DetectCycles2dGrid
{
    private readonly HashSet<(int, int)> visited = [];

    public bool ContainsCycle(char[][] grid) 
    {
        visited.Clear();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (!visited.Contains((i, j)))
                {
                    if (Dfs(grid, i, j))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool Dfs(char[][] grid, int i, int j, int prevI = -1, int prevJ = -1)
    {
        if (visited.Contains((i, j)))
        {
            return true;
        }

        visited.Add((i, j));

        foreach ((int neighborI, int neighborJ) in GetNeighbors(grid, i, j, prevI, prevJ))
        {
            if (Dfs(grid, neighborI, neighborJ, i, j))
            {
                return true;
            }
        }

        return false;
    }

    private static List<(int, int)> GetNeighbors(char[][] grid, int i, int j, int prevI, int prevJ) =>
        [.. new List<(int, int)>
        {
            (i - 1, j),
            (i + 1, j),
            (i, j - 1),
            (i, j + 1)
        }.Where(neighbor => IsValid(grid, neighbor.Item1, neighbor.Item2, prevI, prevJ, grid[i][j]))];

    private static bool IsValid(char[][] grid, int i, int j, int prevI, int prevJ, char value) => 
        i >= 0 && i < grid.Length && j >= 0 && j < grid[0].Length && (i, j) != (prevI, prevJ) && grid[i][j] == value;
}