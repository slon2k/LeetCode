namespace LeetCode.LeetCode75;

public class TribonacciNumber
{
    public class Solution
    {
        public int Tribonacci(int n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            Stack<int> stack = new Stack<int>();

            stack.Push(0);
            stack.Push(1);
            stack.Push(1);

            for (int i = 3; i <= n; i++)
            {
                int n2 = stack.Pop();
                int n1 = stack.Pop();
                int n0 = stack.Pop();

                int sum = n0 + n1 + n2;

                stack.Push(n1);
                stack.Push(n2);
                stack.Push(sum);
            }

            return stack.Pop();
        }
    }
}
