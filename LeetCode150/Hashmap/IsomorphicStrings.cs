namespace LeetCode.LeetCode150.Hashmap;

public class IsomorphicStrings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) 
            {
                return false;
            }

            Dictionary<char, char> mapping = new();
            HashSet<char> used = new();

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];

                if (mapping.ContainsKey(letter) && mapping[letter] != t[i])
                {
                    return false;
                }

                if (!mapping.ContainsKey(letter))
                {
                    if (used.Contains(t[i]))
                    {
                        return false;
                    }

                    used.Add(t[i]);
                    mapping.Add(letter, t[i]);
                }
            }

            return true;
        }
    }
}
