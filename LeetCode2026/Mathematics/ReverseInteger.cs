namespace LeetCode2026.Mathematics;


// 7. Reverse Integer
// Given a signed 32-bit integer x, return x with its digits reversed. 
// If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0

public class Solution
{
    public int Reverse(int x) => x switch
    {
        < 0 => -ReverseDigits(-x),
        _ => ReverseDigits(x)
    };

    private static int ReverseDigits(long x)
    {
        long reversed = 0;
        
        while (x != 0)
        {
            long digit = x % 10;
            x /= 10;

            reversed = reversed * 10 + digit;

            if (IsOverflow(reversed))
                return 0;   
        }

        return (int)reversed;
    }

    private static bool IsOverflow(long x)
    {
        return x > int.MaxValue || x < int.MinValue;
    }
}