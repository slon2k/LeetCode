namespace LeetCode2026.Strings;

// 796. Rotate String
// Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s. A shift on s consists of moving the leftmost character of s to the rightmost position.
// For example, if s = "abcde", then it will be "bcdea" after one shift.

public class RotateStrings
{
    public bool RotateString(string s, string goal) 
    {
        if (s.Length != goal.Length)
        {
            return false;
        }

        string doubledS = s + s;
        return doubledS.Contains(goal);
    }
}