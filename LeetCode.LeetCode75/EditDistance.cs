namespace LeetCode.LeetCode75;

public class EditDistance
{
    public class Solution
    {
        private readonly Dictionary<(string, string), int> distances = new();

        public int MinDistance(string word1, string word2)
        {
            distances.Clear();
            return FindDistance(word1, word2);
        }

        private int FindDistance(string word1, string word2)
        {
            int result  = 0;

            if (distances.ContainsKey((word1, word2)))
            {
                return distances[(word1, word2)];
            }

            if (word1.Length == 0)
            {
                return word2.Length;
            }

            if (word2.Length == 0)
            {
                return word1.Length;
            }

            string sub1 = word1[..^1];
            string sub2 = word2[..^1];

            if (word1[^1] == word2[^1])
            {
                result = FindDistance(sub1, sub2);
            } else
            {
                result =  Min(FindDistance(word1, sub2), FindDistance(sub1, word2), FindDistance(sub1, sub2)) + 1;
            }

            distances.Add((word1, word2), result);

            return result;
        }

        private static int Min(int a, int b, int c) => Math.Min(a, Math.Min(b, c));
    }
}
