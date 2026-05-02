namespace LeetCode2026.Mathematics;

// 788. Rotated Digits
// An integer x is a good number if after rotating each digit individually by 180 degrees, we get a valid number that is different from x. 
// Each digit must be rotated - we cannot choose to leave it alone. 
// A number is valid if each digit remains a digit after rotation. 0, 1, 8 remain the same, 2 and 5 swap, 6 and 9 swap, and 3, 4, 7 become invalid.
// Given an integer n, return the number of good integers in the range [1, n].

public class RotateDigits
{
    public int RotatedDigits(int n) 
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            if (IsGoodNumber(i))
            {
                count++;
            }
        }

        return count;
    }

    private static bool IsGoodNumber(int num)
    {
        bool hasValidRotation = false;

        while (num > 0)
        {
            int digit = num % 10;

            if (digit == 3 || digit == 4 || digit == 7)
            {
                return false;
            }
            if (digit == 2 || digit == 5 || digit == 6 || digit == 9)
            {
                hasValidRotation = true;
            }
            num /= 10;
        }

        return hasValidRotation;
    }
}