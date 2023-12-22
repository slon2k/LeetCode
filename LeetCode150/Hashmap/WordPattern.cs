namespace LeetCode.LeetCode150.Hashmap;

public class WordPattern
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');

            if (pattern.Length != words.Length)
            {
                return false;
            }

            HashSet<string> used = new();
            Dictionary<char, string> map = new();

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];
                string word = words[i];

                if (map.ContainsKey(c) && map[c] != word)
                {
                    return false;
                }

                if (!map.ContainsKey(c) && used.Contains(word))
                {
                    return false;
                }

                if(!map.ContainsKey(c) && !used.Contains(word))
                {
                    map[c] = word;
                    used.Add(word);
                }
            }

            return true;
        }
    }
}
