namespace LeetCode.LeetCode75;

public class DominoAndTrominoTiling
{
    public class Solution
    {
        private readonly int mod = 1_000_000_000 + 7;
        
        private Dictionary<int, int> f = new();

        private Dictionary<int, int> f1 = new();


        public int NumTilings(int n)
        {
            return CountF(n);
        }

        private int CountF(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            if (f.ContainsKey(n))
            {
                return f[n];
            }

            long result = 2 * CountF1(n - 1);
            
            result += CountF(n - 1);
            result += CountF(n - 2);
            result %= mod;

            f[n] = (int)result;

            return f[n];
        }

        private int CountF1(int n)
        {
            if (n == 2)
            {
                return 1;               
            }

            if (n < 2)
            {
                return 0;
            }

            if (f1.ContainsKey(n))
            {
                return f1[n];
            }

            long result = CountF(n - 2) + CountF1(n - 1);

            result %= mod;

            f1[n] = (int)result;

            return f1[n];
        }
    }
}
