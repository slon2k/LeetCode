namespace LeetCode.LeetCode150.ArrayString;

public class Candy
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int[] candies = Enumerable.Repeat(1, ratings.Length).ToArray();

            for (int i = 1; i < candies.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            return candies.Sum();
        }
    }
}
