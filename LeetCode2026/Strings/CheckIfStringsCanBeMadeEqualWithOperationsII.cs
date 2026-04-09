namespace LeetCode2026.Strings;

// 2840. Check if Strings Can Be Made Equal With Operations II
// You are given two strings s1 and s2, both of length n, consisting of lowercase English letters.
// You can apply the following operation on any of the two strings any number of times:
// Choose any two indices i and j such that i < j and the difference j - i is even, then swap the two characters at those indices in the string.
// Return true if you can make the strings s1 and s2 equal, and false otherwise.

public class CheckIfStringsCanBeMadeEqualWithOperationsIISolution
{
    public bool CheckStrings(string s1, string s2) 
    {
        if (s1.Length != s2.Length) {
            return false;
        }

        int n = s1.Length;
        List<char> s1Even = new List<char>();
        List<char> s1Odd = new List<char>();
        List<char> s2Even = new List<char>();
        List<char> s2Odd = new List<char>();

        for (int i = 0; i < n; i++) {
            if (i % 2 == 0) {
                s1Even.Add(s1[i]);
                s2Even.Add(s2[i]);
            } else {
                s1Odd.Add(s1[i]);
                s2Odd.Add(s2[i]);
            }
        }

        char[] s1EvenArr = s1Even.ToArray();
        char[] s1OddArr = s1Odd.ToArray();
        char[] s2EvenArr = s2Even.ToArray();
        char[] s2OddArr = s2Odd.ToArray();

        Array.Sort(s1EvenArr);
        Array.Sort(s1OddArr);
        Array.Sort(s2EvenArr);
        Array.Sort(s2OddArr);

        return new string(s1EvenArr) == new string(s2EvenArr) && new string(s1OddArr) == new string(s2OddArr);
    }
}