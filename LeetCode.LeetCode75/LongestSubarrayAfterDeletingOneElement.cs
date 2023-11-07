namespace LeetCode.LeetCode75;

public class LongestSubarrayAfterDeletingOneElement
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            int left = 0, right = 0, maxLength = 0, count = nums[0] == 0 ? 1 : 0;

            while (right < nums.Length)
            {

                if (count <= 1)
                {
                    int length = right - left;
                    
                    maxLength = length > maxLength ? length : maxLength;
                    
                    right++;

                    if (right == nums.Length)
                    {
                        break;
                    }

                    if (nums[right] == 0)
                    {
                        count++;
                    }
                    
                    continue;
                }

                if (nums[left] == 0)
                {
                    count--;
                }

                left++;
            }

            return maxLength;
        }
    }
}
