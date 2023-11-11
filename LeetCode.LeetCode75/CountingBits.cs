namespace LeetCode.LeetCode75;

public class CountingBits
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            var list = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                list.Add(Count(i));
            }

            return list.ToArray();
        }

        private int Count(int n)
        {
            int count = 0;
            
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    count++;
                }

                n /= 2;
            }

            return count;
        }
    }
}
