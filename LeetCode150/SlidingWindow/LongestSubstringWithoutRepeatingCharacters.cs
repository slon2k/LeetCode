namespace LeetCode.LeetCode150.SlidingWindow;

public class LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int left = 0;
            int right = 0;
            int maxLength = 1;
            string current = s[0].ToString();

            while (left < s.Length && right < s.Length)
            {
                right++;

                if (right == s.Length)
                {
                    break;
                }

                while (current.Contains(s[right]))
                {
                    left++;
                    current = current[1..];
                }

                current += s[right];
                maxLength = Math.Max(maxLength, current.Length);
            }

            return maxLength;
        }
    }
}
