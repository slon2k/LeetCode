namespace LeetCode.LeetCode75;

public class UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            int[,] paths = new int[m + 1, n + 1];

            paths[1, 1] = 1;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    paths[i, j] = paths[i - 1, j] + paths[i, j - 1]; 
                }
            }

            return paths[m, n];
        }
    }
}
