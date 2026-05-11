namespace LeetCode2026.Arrays;

// 2553. Separate the Digits in an Array
// You are given a positive integer array nums.
// For each integer in nums, separate the digits and add them to a new list in the same order.
// Return the new list.

public class SeparateDigitsInArray
{
    public int[] SeparateDigits(int[] nums)
    {
        var result = new List<int>();

        foreach (var num in nums)
        {
            var digits = GetDigits(num);
            result.AddRange(digits);
        }

        return result.ToArray();
    }

    private IEnumerable<int> GetDigits(int num)
    {
        var stack = new Stack<int>();

        while (num > 0)
        {
            stack.Push(num % 10);
            num /= 10;
        }

        return stack;
    }
}