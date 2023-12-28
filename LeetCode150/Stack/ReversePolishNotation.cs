namespace LeetCode.LeetCode150.Stack;

public class ReversePolishNotation
{
    public class Solution
    {
        private const string operations = "+-/*";

        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new();

            foreach (var token in tokens)
            {
                if (operations.Contains(token))
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(Count(a, b, GetOperation(token)));
                } else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }

        private static int Count(int a, int b, Func<int, int, int> operation) => operation(a, b);

        private static Func<int, int, int> GetOperation(string operation) => operation switch
        {
            "+" => (int a, int b) => a + b,
            "-" => (int a, int b) => a - b,
            "/" => (int a, int b) => a / b,
            "*" => (int a, int b) => a * b,
            _ => throw new NotImplementedException(),
        };
    }
}
