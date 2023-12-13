namespace LeetCode.LeetCode150.ArrayString;

public class LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            
            if (strs.Length == 0)
            {
                return result;
            }

            int minLength = strs.Select(s => s.Length).Min();

            Array.Sort(strs);

            string first = strs[0];
            string last = strs[^1];

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] == last[i])
                {
                    result += first[i];
                } else
                {
                    break;
                }
            }

            return result;
        }
    }
}
