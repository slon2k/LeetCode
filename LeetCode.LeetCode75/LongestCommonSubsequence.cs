namespace LeetCode.LeetCode75;

public class LongestCommonSubsequence
{
    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var (length1, length2) = (text1.Length, text2.Length);

            int[,] result = new int[length1 + 1, length2 + 1];

            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length2; j++)
                {
                    result[i, j] = Math.Max(result[i - 1, j], result[i, j - 1]);

                    if (text1[i - 1] == text2[j - 1] && result[i - 1, j] >= result[i, j - 1])
                    {
                        result[i, j]++;
                        result[i, j] -= result[i - 1, j] - result[i - 1, j - 1];
                    }
                }
            }

            return result[length1, length2];
        }
    }
}
