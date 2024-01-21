namespace LeetCode.LeetCode150.Mathematics;

internal class Pow
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (x == 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return 1;
            }

            int sign = n % 2 == 0 ? 1 : x < 0 ? -1 : 1;
            
            x = System.Math.Abs(x);

            if (n < 0)
            {
                long p = n;
                return sign / Pow(x, System.Math.Abs(p));
            }

            return sign * Pow(x, n);
        }

        private double Pow(double x, long n)
        {
            if (n == 1)
            {
                return x;
            }

            if (n % 2 == 0)
            {
                double value = Pow(x, n / 2);
                return value * value;
            } else
            {
                return x * Pow(x, n - 1);
            }
        }
    }
}
