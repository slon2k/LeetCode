namespace LeetCode.LeetCode150.Math;

internal class PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var digits = GetDigits(x);

            var reversed = digits.Reverse();

            return digits.SequenceEqual(reversed);
        }

        IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }
    }
}
