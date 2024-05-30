namespace LeetCode.LeetCode150.DP;

public class LongestPalindromicSubstring
{
    public class Solution
    {
        private readonly HashSet<(int, int)> palindromes = [];

        public string LongestPalindrome(string s)      
        {
            palindromes.Clear();
            return FindPalindrome(s);
        }


        private string FindPalindrome(string s)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                palindromes.Add((i, i));

                answer = s.Substring(i, 1);
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    palindromes.Add((i - 1, i));
                    answer = s.Substring(i - 1, 2);
                }
            }

            for (int size = 2; size < s.Length; size++)
            {
                for(int i = 0; i + size < s.Length; i++)
                {
                    if (s[i] == s[i + size] && palindromes.Contains((i + 1, i + size - 1)))
                    {
                        palindromes.Add((i, i + size));
                        answer = s.Substring(i, size + 1);
                    }
                }
            }

            return answer;
        }
    }
}
