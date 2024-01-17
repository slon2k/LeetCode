namespace LeetCode.LeetCode150.Math;

internal class PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int toAdd = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += toAdd;

                toAdd = digits[i] / 10;

                digits[i] %= 10;
            }

            if (toAdd == 0)
            {
                return digits;
            }

            var result = new List<int> { 1 };
            result.AddRange(digits);

            return result.ToArray();
        }
    }
}
