namespace LeetCode.LeetCode150.DP;

public class MinimumPathSum
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            int height = grid.Length;
            int width = grid[0].Length;

            int[,] result = new int[height + 1, width + 1];

            for (int i = 0; i <= height; i++)
            {
                result[i, 0] = int.MaxValue;
            }

            for (int j = 0; j <= width; j++)
            {
                result[0, j] = int.MaxValue;
            }

            result[0, 1] = 0;
            result[1, 0] = 0;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    result[i, j] = grid[i - 1][j - 1] + Math.Min(result[i - 1, j], result[i, j - 1]);
                }
            }

            return result[height, width];
        }
    }
}
