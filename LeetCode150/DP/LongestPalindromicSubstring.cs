namespace LeetCode.LeetCode150.DP;

public class LongestPalindromicSubstring
{
    public class Solution
    {
        const int maxSize = 1000;

        private readonly bool[,] palindromes = new bool[maxSize, maxSize];

        public string LongestPalindrome(string s)      
        {
            return FindPalindrome(s);
        }


        private string FindPalindrome(string s)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                palindromes[i, i] = true;

                answer = s.Substring(i, 1);
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    palindromes[i - 1, i] = true;
                    answer = s.Substring(i - 1, 2);
                }
            }

            for (int size = 2; size < s.Length; size++)
            {
                for(int i = 0; i + size < s.Length; i++)
                {
                    if (s[i] == s[i + size] && palindromes[i + 1, i + size - 1] == true)
                    {
                        palindromes[i, i + size] = true;
                        answer = s.Substring(i, size + 1);
                    }
                }
            }

            return answer;
        }
    }
}
