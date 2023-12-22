namespace LeetCode.LeetCode150.Hashmap;

public class RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> letters = new();

            foreach (char c in magazine)
            {
                if (letters.ContainsKey(c))
                {
                    letters[c]++;
                } else
                {
                    letters[c] = 1;
                }
            }

            foreach (char c in ransomNote)
            {
                if (!letters.ContainsKey(c))
                {
                    return false;
                }

                letters[c]--;

                if (letters[c] == 0)
                {
                    letters.Remove(c);
                }
            }

            return true;
        }
    }
}
