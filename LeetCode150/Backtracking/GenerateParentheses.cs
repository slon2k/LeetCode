namespace LeetCode.LeetCode150.Backtracking;

public class GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            if (n == 0)
            {
                return result;
            }

            Queue<string> queue = new();

            queue.Enqueue("(");

            while (queue.Count > 0)
            {
                string str = queue.Dequeue();

                var left = CountChar(str, '(');
                var right = CountChar(str, ')');

                if (left == n && right == n)
                {
                    result.Add(str);
                    continue;
                }

                if (left < n)
                {
                    queue.Enqueue(str + '(');
                }

                if (right < n && right < left)
                {
                    queue.Enqueue(str + ')');
                }
            }

            return result.ToList();
        }

        private static int CountChar(string s, char c) => s.Where(x => x == c).Count();
    }
}
