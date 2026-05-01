namespace LeetCode2026.Mathematics;

// 396. Rotate Function
// You are given an integer array nums of length n.
// Assume arrk to be an array obtained by rotating nums by k positions clock-wise. 
// We define the rotation function F on nums as follow:

// F(k) = 0 * arrk[0] + 1 * arrk[1] + ... + (n - 1) * arrk[n - 1].
// Return the maximum value of F(0), F(1), ..., F(n-1).
// The test cases are generated so that the answer fits in a 32-bit integer.

public class RotateFunction
{
    public int MaxRotateFunction(int[] nums) 
    {
        int n = nums.Length;
        int sum = 0;
        long functionValue = 0;

        for (long i = 0; i < n; i++)
        {
            sum += nums[i];
            functionValue += i * nums[i];
        }

        long maxValue = functionValue;

        for (long i = n - 1; i > 0; i--)
        {
            functionValue = functionValue + sum - n * nums[i];
            if (functionValue > maxValue)
            {
                maxValue = functionValue;
            }
        }

        return (int)maxValue;
    }
}