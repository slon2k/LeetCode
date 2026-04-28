namespace LeetCode2026.Graphs;

// 1391. Check if There is a Valid Path in a Grid
// You are given an m x n grid. Each cell of grid represents a street. The street of grid[i][j] can be:
// 1 which means a street connecting the left cell and the right cell.
// 2 which means a street connecting the upper cell and the lower cell.
// 3 which means a street connecting the left cell and the lower cell.
// 4 which means a street connecting the right cell and the lower cell.
// 5 which means a street connecting the left cell and the upper cell.
// 6 which means a street connecting the right cell and the upper cell.
// You will initially start at the street of the upper-left cell (0, 0). A valid path in the grid is a path that starts from the upper left cell (0, 0) and ends at the bottom-right cell (m - 1, n - 1).
// The path should only follow the streets.
// Notice that you are not allowed to change any street.
// Return true if there is a valid path in the grid or false otherwise.


public class CheckIfThereIsValidPathInGrid 
{
    private readonly Dictionary<int, Edge> streetToDirections = new()
    {
        [1] = new Edge(new(0, -1), new (0, 1)),
        [2] = new Edge(new(-1, 0), new(1, 0)),
        [3] = new Edge(new(0, -1), new(1, 0)),
        [4] = new Edge(new(0, 1), new(1, 0)),
        [5] = new Edge(new(0, -1), new(-1, 0)),
        [6] = new Edge(new(0, 1), new(-1, 0))
    };

    private readonly HashSet<Vertex> visited = [];

    private readonly Dictionary<Vertex, List<Vertex>> graph = [];

    public bool HasValidPath(int[][] grid) 
    {
        visited.Clear();
        graph.Clear();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                var vertex = new Vertex(i, j);
                var direction = streetToDirections[grid[i][j]];
                var from = new Vertex(i + direction.From.X, j + direction.From.Y);
                var to = new Vertex(i + direction.To.X, j + direction.To.Y);
                graph[vertex] = [];
                
                if (IsValidVertex(from, grid) && CanConnectBack(from, vertex, grid))
                {
                    graph[vertex].Add(from);
                }

                if (IsValidVertex(to, grid) && CanConnectBack(to, vertex, grid))
                {
                    graph[vertex].Add(to);
                }
            }
        }

        var start = new Vertex(0, 0);
        var target = new Vertex(grid.Length - 1, grid[0].Length - 1);

        return Dfs(start, target);
    }

    private bool Dfs(Vertex vertex, Vertex target)
    {
        if (vertex == target)
        {
            return true;
        }

        visited.Add(vertex);

        foreach (Vertex neighbor in graph[vertex])
        {
            if (!visited.Contains(neighbor) && Dfs(neighbor, target))
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsValidVertex(Vertex vertex, int[][] grid) =>
        vertex.X >= 0 && vertex.X < grid.Length && vertex.Y >= 0 && vertex.Y < grid[0].Length;

    private bool CanConnectBack(Vertex from, Vertex to, int[][] grid)
    {
        var direction = streetToDirections[grid[from.X][from.Y]];
        var first = new Vertex(from.X + direction.From.X, from.Y + direction.From.Y);
        var second = new Vertex(from.X + direction.To.X, from.Y + direction.To.Y);
        return first == to || second == to;
    }

    public record struct Vertex(int X, int Y);

    public record struct Edge(Vertex From, Vertex To);
}