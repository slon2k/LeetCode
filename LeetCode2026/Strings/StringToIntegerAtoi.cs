namespace LeetCode2026.Strings;

// 8. String to Integer (atoi)
// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.
// The algorithm for myAtoi(string s) is as follows:
// Whitespace: Ignore any leading whitespace (" ").
// Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
// Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0.
// Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
// Return the integer as the final result.

public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.TrimStart();
        
        if (string.IsNullOrWhiteSpace(s))
            return 0;
        
        int sign = 1;

        if (s[0] == '-' || s[0] == '+')
        {
            sign = s[0] == '-' ? -1 : 1;
            s = s[1..];
        }

        long result = 0;

        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                break;

            result = result * 10 + (c - '0');

            if (sign == 1 && result > int.MaxValue)
                return int.MaxValue;
            
            if (sign == -1 && -result < int.MinValue)
                return int.MinValue;
        }

        return (int)(sign * result);
    }
}