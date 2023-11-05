namespace LeetCode.LeetCode75;

public class ReverseWordsInString
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            while (true)
            {
                if (s.Contains("  "))
                {
                    s = s.Replace("  ", " ");
                } else
                {
                    break;
                }
            }

            var words = s.Trim().Split(' ');

            return string.Join(' ', words.Reverse());
        }
    }
}
