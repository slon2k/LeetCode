namespace LeetCode.LeetCode150.Mathematics;

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

            var str = Convert.ToString(x);

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left++] != str[right--])
                {
                    return false;
                }
            }
           
            return true;
        }
    }
}
