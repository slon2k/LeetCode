namespace LeetCode2026.Strings;
// 1415. The k-th Lexicographical String of All Happy Strings of Length n
// A happy string is a string that:
// consists only of letters of the set ['a', 'b', 'c'].
// satisfies that s[i] != s[i + 1] for all values of i from 1 to s.length - 1 (string is 1-indexed).
// For example, "abc", "ac", "b" and "abcbab" are happy strings and "aa", "baa" and "ababbc" are not happy strings.
// Given two integers n and k, consider a list of all happy strings of length n sorted in lexicographical order.
// Return the k-th string in this list or an empty string if there are less than k happy strings of length n.

public class LexicographicalAllHappyStrings
{
    public class Solution 
    {
        public string GetHappyString(int n, int k) 
        {
            string alphabet = "abc";
            var happyStrings = new List<string>();
            var queue = new Queue<string>();
            
            queue.Enqueue("");

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();

                if (current.Length == n)
                {
                    happyStrings.Add(current);

                    if (happyStrings.Count == k)
                    {
                        return happyStrings[^1];
                    }
                }
                else
                {
                    foreach (char c in alphabet)
                    {
                        if (current.Length == 0 || current[^1] != c)
                        {
                            queue.Enqueue(current + c);
                        }
                    }
                }
            }

            return "";
        }
    }
}
