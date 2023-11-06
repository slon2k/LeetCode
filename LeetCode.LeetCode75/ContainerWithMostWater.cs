namespace LeetCode.LeetCode75;

public class ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int length = height.Length;

            int left = 0, right = length - 1;

            int maxArea = 0;

            while (left < right)
            {
                int area = Area(height, left, right);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        private int Area(int[] a, int left, int right)
        {
            int height = a[left] < a[right] ? a[left] : a[right];
            return height * (right - left);
        }
    }
}
