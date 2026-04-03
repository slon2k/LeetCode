namespace LeetCode2026.DynamicProgramming;

// 3418. Maximum Amount of Money Robot Can Earn
// A robot is located at the top-left corner of an m x n grid (marked 'Start' in the diagram below). 
// The robot tries to move to the bottom-right corner of the grid (marked 'Finish' in the diagram below).
// The robot can only move either down or right at any point in time. Each cell of the grid contains a certain amount of money. 
// The robot can collect the money in each cell it passes through. 
// Return the maximum amount of money that the robot can collect by the time it reaches the bottom-right corner of the grid.
// The robot has a special ability to neutralize robbers in at most 2 cells on its path, preventing them from stealing coins in those cells.

public class MaximumAmountOfMoneyRobotCanEarn
{
    public class Solution
    {
        public int MaximumAmount(int[][] coins)
        {
            int m = coins.Length;
            int n = coins[0].Length;
            long[,,] dp = new long[m, n, 3]; // dp[i, j, k] = max coins at (i, j) with k neutralizations used
            long neg = long.MinValue / 2; // sentinel for "unreachable" direction

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int currentCoins = coins[i][j];
                    if (i == 0 && j == 0)           
                    {
                        dp[0, 0, 0] = currentCoins;
                        dp[0, 0, 1] = 0; // Neutralize the first cell
                        dp[0, 0, 2] = 0; // Neutralize the first cell
                        continue;
                    }

                    for (int k = 0; k <= 2; k++)
                    {
                        long fromTop = i > 0 ? dp[i - 1, j, k] : neg;
                        long fromLeft = j > 0 ? dp[i, j - 1, k] : neg;
                        dp[i, j, k] = Math.Max(fromTop, fromLeft) + currentCoins;

                        if (k > 0)
                        {
                            long neutralizeFromTop = i > 0 ? dp[i - 1, j, k - 1] : neg;
                            long neutralizeFromLeft = j > 0 ? dp[i, j - 1, k - 1] : neg;
                            dp[i, j, k] = Math.Max(dp[i, j, k], Math.Max(neutralizeFromTop, neutralizeFromLeft));
                        }
                    }
                }
            }
            return (int)Math.Max(dp[m - 1, n - 1, 0], Math.Max(dp[m - 1, n - 1, 1], dp[m - 1, n - 1, 2]));

        }
    }
}