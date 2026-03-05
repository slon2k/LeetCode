namespace LeetCode2026.Strings;

// 1758. Minimum Changes To Make Alternating Binary String
// Given a string s consisting only of the characters '0' and '1', return the
// minimum number of character changes needed to make s alternating.
// The string is called alternating if no two adjacent characters are equal.


public class MinimumChangesToMakeAlternatingBinaryString
{
    public class Solution 
    {
        // O(n) time, O(1) space
        public int MinOperations(string s)
        {
            int changes1 = 0, changes2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != (i % 2 == 0 ? '0' : '1')) changes1++;
                if (s[i] != (i % 2 == 0 ? '1' : '0')) changes2++;
            }
            return Math.Min(changes1, changes2);
        }
    }
}