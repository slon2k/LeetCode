namespace LeetCode.LeetCode150.Stack;

internal class ValidParentheses
{
    public class Solution
    {
        private readonly string opening = "({[";
        private readonly string closing = ")}]";

        public bool IsValid(string s)
        {
            Stack<char> stack = new ();

            foreach (char c in s)
            {
                if (opening.Contains(c))
                {
                    stack.Push (c);
                } else if (closing.Contains(c))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    var previous = stack.Pop();

                    if (!IsCorrect(previous, c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool IsCorrect(char c1, char c2) => (c1 == '(' && c2 == ')') || (c1 == '[' && c2 == ']') || (c1 == '{' && c2 == '}');
    }
}
