using System.Text;

namespace LeetCode.LeetCode150.TwoPointers;

public class ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var str = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    str.Append(c);
                }
            }

            string alphanumeric  = str.ToString().ToLower();

            int left = 0;
            int right = alphanumeric.Length - 1;

            while (left < right)
            {
                if (alphanumeric[left++] != alphanumeric[right--]) 
                {
                    return false;
                }
            }

            return true;
        }
    }
}
