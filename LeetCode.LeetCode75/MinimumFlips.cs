namespace LeetCode.LeetCode75;

public class MinimumFlips
{
    public class Solution
    {
        public int MinFlips(int a, int b, int c)
        {
            int result = 0;

            while (a > 0 || b > 0 || c > 0 ) 
            {
                result += CountOperations(a % 2, b % 2, c % 2);
                
                a /= 2;
                b /= 2;
                c /= 2;
            }

            return result;
        }

        int CountOperations(int a, int b, int c) => (a, b, c) switch
        {
            (0, 0, 0) => 0,
            (0, 1, 0) => 1,
            (1, 0, 0) => 1,
            (1, 1, 0) => 2,
            (0, 0, 1) => 1,
            (0, 1, 1) => 0,
            (1, 0, 1) => 0,
            (1, 1, 1) => 0,
            _ => 0
        };
    }
}
