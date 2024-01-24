namespace LeetCode.LeetCode150.Backtracking;

public class Combinations
{
    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Queue<(int number, IList<int> path)> queue = new();

            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue((i, new List<int>()));
            }

            while (queue.Count > 0)
            {
                var (number, path) = queue.Dequeue();

                path.Add(number);

                if (path.Count == k)
                {
                    result.Add(path);

                    continue;
                }

                for (int i = number + 1; i <= n; i++)
                {
                    queue.Enqueue((i, new List<int>(path)));
                }
            };

            return result;
        }
    }
}
