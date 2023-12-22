namespace LeetCode.LeetCode150.Hashmap;

public class ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            return new string(s.Order().ToArray()) == new string(t.Order().ToArray());
        }
    }
}
