namespace LeetCode.LeetCode75;

public class IncreasingTripletSubsequence
{
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var length = nums.Length;

            int[] minLeft = new int[length];
            int[] maxRight = new int[length];

            int min = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                
                minLeft[i] = min;
            }

            int max = int.MinValue;

            for (int i = length - 1; i >= 0; i--)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

                maxRight[i] = max;
            }

            for (int i = 1; i < length - 1; i++)
            {
                if (nums[i] > minLeft[i - 1] && nums[i] < maxRight[i + 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
