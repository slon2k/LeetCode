using System.Text;

namespace LeetCode.LeetCode75;

public class RemovingStarsFromString
{
    public class Solution
    {
        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '*')
                {
                    stack.Pop();
                } else
                {
                    stack.Push(c);
                }
            }

            var sb = new StringBuilder();

            foreach (char c in stack)
            {
                sb.Append(c);
            }

            var result = sb.ToString().Reverse().ToArray();

            return new string(result);
        }
    }
}
