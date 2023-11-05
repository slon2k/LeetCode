using System.Text;

namespace LeetCode.LeetCode75;

public class ReverseVowelsOfString
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            var vowels = s.Where(IsVowel).Reverse().ToList();

            int i = 0;

            var sb = new StringBuilder();

            foreach (var c in s)
            {
                if (IsVowel(c))
                {
                    sb.Append(vowels[i++]);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        private List<char> Vowels = new()
        {
            'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
        };

        private bool IsVowel(char c) => Vowels.Contains(c);
    }
}
