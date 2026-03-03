using System.Text;

namespace LeetCode2026.Strings;

// 38. Count and Say
// The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
// countAndSay(1) = "1"
// countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1)
// For example, the saying and counting of "3322251" is "23321511", because there are two 3's, three 2's, one 5 and one 1.
// Given a positive integer n, return the nth term of the count-and-say sequence.

public class CountAndSay
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string previous = CountAndSay(n - 1);
            StringBuilder result = new();
            int count = 1;
            char currentChar = previous[0];

            for (int i = 1; i < previous.Length; i++)
            {
                if (previous[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(currentChar);
                    currentChar = previous[i];
                    count = 1;
                }
            }
            
            // Append the last counted character
            result.Append(count);
            result.Append(currentChar);
            return result.ToString();
        }
    }
}

    