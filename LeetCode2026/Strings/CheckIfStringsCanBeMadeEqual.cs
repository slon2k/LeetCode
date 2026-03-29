namespace LeetCode2026.Strings;

// 2839. Check if Strings Can be Made Equal With Operations I
// You are given two strings s1 and s2, both of length 4, consisting of lowercase English letters.
// Choose any two indices i and j such that j - i = 2, then swap the two characters at those indices in the string.
// You can perform this operation any number of times.
// Return true if it is possible to make s1 and s2 equal, and false otherwise.

public class CheckIfStringsCanBeMadeEqual
{
    public class Solution
    {
        // O(1) time, O(1) space
        public bool CanBeEqual(string s1, string s2)
        {
            if (s1.Length != 4 || s2.Length != 4) return false;

            if (s1[0] != s2[0] && s1[0] != s2[2]) return false;
            if (s1[1] != s2[1] && s1[1] != s2[3]) return false;
            if (s1[2] != s2[0] && s1[2] != s2[2]) return false;
            if (s1[3] != s2[1] && s1[3] != s2[3]) return false;

            return true;
        }
    }
}