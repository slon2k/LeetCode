
namespace LeetCode.LeetCode150.DP;

public class Triangle
{
    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            List<List<int>> results = [];

            int height = triangle.Count;

            results.Add([triangle[0][0]]);

            for (int i = 1; i < height; i++)
            {
                results.Add([]);

                for (int j = 0; j < triangle[i].Count; j++)
                {
                    int current;
                    
                    if (j == 0)
                    {
                        current = results[i - 1][0];
                    } else if (j == triangle[i].Count - 1)
                    {
                        current = results[i - 1][j - 1];
                    } else
                    {
                        current = Math.Min(results[i - 1][j], results[i - 1][j - 1]);
                    }

                    results[i].Add(current + triangle[i][j]);
                }
            }

            return results[height - 1].Min();
        }
    }
}
