namespace LeetCode.LeetCode150.DP;

public class LongestPalindromicSubstring
{
    public class Solution
    {
        private readonly HashSet<string> palindromes = new();

        private readonly Dictionary<string, string> results = new();

        public string LongestPalindrome(string s)      
        {
            palindromes.Clear();
            results.Clear();

            return FindPalindrome(s);
        }


        private string FindPalindrome(string s)
        {
            if(IsPalindrome(s))
            {
                results[s] = s;
                return s;
            }

            if(results.ContainsKey(s))
            {
                return results[s];
            }


            string leftSubstring = s[..^1];
            string left = FindPalindrome(leftSubstring);

            string rightSubstring = s[1..];
            string right = FindPalindrome(rightSubstring);

            if(left.Length >= right.Length)
            {
                results[s] = left;
                return left;
            }
            else
            {
                results[s] = right;
                return right;
            }
        }

        private bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }

            if (s[0] != s[^1])
            {
                return false;
            }

            if (palindromes.Contains(s))
            {
                return true;
            }

            string substring = s[1..^1];
            bool result = IsPalindrome(substring);

            if (result)
            {
                palindromes.Add(s);
            }

            return result;
        }
    }
}
