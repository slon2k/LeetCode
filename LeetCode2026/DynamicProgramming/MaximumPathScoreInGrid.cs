namespace LeetCode2026.DynamicProgramming;

// 3742. Maximum Path Score in a Grid
// You are given an m x n grid where each cell contains one of the values 0, 1, or 2. 
// You are also given an integer k.
// You start from the top-left corner (0, 0) and want to reach the bottom-right corner (m - 1, n - 1) by moving only right or down.
// Each cell contributes a specific score and incurs an associated cost, according to their cell values:
// 0: adds 0 to your score and costs 0.
// 1: adds 1 to your score and costs 1.
// 2: adds 2 to your score and costs 1. ​​​​​​​
// Return the maximum score achievable without exceeding a total cost of k, or -1 if no valid path exists.
// Note: If you reach the last cell but the total cost exceeds k, the path is invalid.

public class MaximumPathScoreInGrid
{
    private const int Unreachable = -1;

    public int MaxPathScore(int[][] grid, int k)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int maxScore = Unreachable;

        var dp = new int[rows, cols, k + 1];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int cost = 0; cost <= k; cost++)
                {
                    dp[i, j, cost] = Unreachable;
                }
            }
        }

        int startCost = GetCost(grid[0][0]);
        if (startCost > k) return -1;
        dp[0, 0, startCost] = grid[0][0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int cost = 0; cost <= k; cost++)
                {
                    if (dp[i, j, cost] == Unreachable) continue;

                    int currentScore = dp[i, j, cost];

                    if (j + 1 < cols)
                    {
                        RelaxTransition(dp, grid, i, j + 1, k, cost, currentScore);
                    }

                    if (i + 1 < rows)
                    {
                        RelaxTransition(dp, grid, i + 1, j, k, cost, currentScore);
                    }
                }
            }
        }

        for (int cost = 0; cost <= k; cost++)
        {
            maxScore = Math.Max(maxScore, dp[rows - 1, cols - 1, cost]);
        }

        return maxScore;
    }

    private static int GetCost(int cellValue) => cellValue switch
    {
        0 => 0,
        1 => 1,
        2 => 1,
        _ => throw new ArgumentException("Invalid cell value")
    };

    private static void RelaxTransition(int[,,] dp, int[][] grid, int row, int col, int k, int cost, int score)
    {
        int newCost = cost + GetCost(grid[row][col]);
        if (newCost <= k)
        {
            dp[row, col, newCost] = Math.Max(dp[row, col, newCost], score + grid[row][col]);
        }
    }
}