namespace LeetCode.LeetCode75;

public class TribonacciNumber
{
    public class Solution
    {
        public int Tribonacci(int n)
        {

            if (n == 0) 
                return 0;

            if (n == 1) 
                return 1;

            if (n == 2) 
                return 1;

            int[] buffer = new int[3];

            (buffer[0], buffer[1], buffer[2]) = (0, 1, 1);

            for (int i = 3; i <= n; i++)
            {
                int sum = buffer[0] + buffer[1] + buffer[2];

                (buffer[0], buffer[1], buffer[2]) = (buffer[1], buffer[2], sum);
            }

            return buffer[2];
        }
    }
}
