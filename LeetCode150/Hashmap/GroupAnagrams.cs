namespace LeetCode.LeetCode150.Hashmap;

public class GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> anagrams = new();

            foreach (string str in strs)
            {
                string sorted = new string(str.Order().ToArray());

                if (!anagrams.ContainsKey(sorted))
                {
                    anagrams[sorted] = new List<string>();
                }

                anagrams[sorted].Add(str);
            }

            return anagrams.Values.ToList();
        }
    }
}
