using System.Runtime.Serialization.Formatters;

namespace LeetCode.LeetCode75;

public class MaximumNumberOfVowelsInSubstring
{
    public class Solution
    {
        public int MaxVowels(string s, int k)
        {
            string sub = s.Substring(0, k);

            int count = VowelCount(sub);

            int max = count;

            for (int i = k; i < s.Length; i++)
            {
                char input = s[i];
                char output = s[i - k];

                if (IsVowel(input))
                {
                    count++;
                }

                if (IsVowel(output))
                {
                    count--;
                }

                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }

        private const string Vowels = "aeiouAEIOU";

        private bool IsVowel(char c) => Vowels.Contains(c);

        private int VowelCount(string s) => s.Where(IsVowel).Count();
    }
}
