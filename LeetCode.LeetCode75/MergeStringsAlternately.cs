using System.Text;

namespace LeetCode.LeetCode75;

public class MergeStringsAlternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Maximum(word1.Length, word2.Length); i++)
            {
                sb.Append(GetLetter(word1, i));
                sb.Append(GetLetter(word2, i));
            }

            return sb.ToString();
        }

        private string GetLetter(string word, int i) => i < word.Length ? word[i].ToString() : "";

        private int Maximum(int a, int b) => a > b ? a : b;
    }
}
