namespace LeetCode.LeetCode150.ArrayString;

public class TrappingRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int length = height.Length;

            int[] left = new int[length];
            int[] right = new int[length];

            int maxLeft = int.MinValue;

            for (int i = 0; i < length; i++)
            {                
                if (height[i] > maxLeft)
                {
                    maxLeft = height[i];
                }

                left[i] = maxLeft;
            }

            int maxRight = int.MinValue;

            for (int i = length - 1; i >= 0; i--)
            {
                if (height[i] > maxRight)
                {
                    maxRight = height[i];
                }

                right[i] = maxRight;
            }

            int result = 0;

            for (int i = 1; i < length - 1; i++)
            {
                int level = Math.Min(left[i - 1], right[i + 1]);

                if (level - height[i] > 0)
                {
                    result += level - height[i];
                }
            }

            return result;
        }
    }
}
