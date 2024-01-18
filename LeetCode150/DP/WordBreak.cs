namespace LeetCode.LeetCode150.DP;

internal class WordBreak
{
    public class Solution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> words = new(wordDict);

            Dictionary<string, bool> results = new();

            return GetResult(s, words, results);
        }

        private bool GetResult(string s, HashSet<string> words, Dictionary<string, bool> results)
        {
            if (words.Contains(s)) 
            {
                return true;
            }
            
            if (results.ContainsKey(s))
            {
                return results[s];
            }

            for (int i = 1; i < s.Length; i++)
            {
                var begin = s[..i];
                var end = s[i..];

                if (words.Contains(begin) && GetResult(end, words, results))
                {
                    results[s] = true;
                    return true;
                }
            }

            results[s] = false;
            return false;
        }
    }
}
