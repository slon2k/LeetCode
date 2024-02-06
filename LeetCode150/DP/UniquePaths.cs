namespace LeetCode.LeetCode150.DP;

public class UniquePaths
{
    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int height = obstacleGrid.Length;
            int width = obstacleGrid[0].Length;

            int[,] result = new int[height + 1, width + 1];
            result[0, 1] = 1;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if (obstacleGrid[i - 1][j - 1] == 0)
                    {
                        result[i, j] = result[i - 1, j] + result[i, j - 1];
                    }
                }
            }

            return result[height, width];
        }
    }
}
