namespace LeetCode.LeetCode150.Mathematics;
internal class Sqrt
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1) 
                return x;

            long left = 0; 
            long right = x;

            while (left < right - 1)
            {
                long middle = left + (right - left) / 2;

                if (middle * middle > x)
                {
                    right = middle;
                } else
                {
                    left = middle;
                }
            }

            return (int)left;
        }
    }
}
