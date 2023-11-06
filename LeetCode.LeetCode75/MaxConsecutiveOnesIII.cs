using System.Runtime.Serialization.Formatters;

namespace LeetCode.LeetCode75;

public class MaxConsecutiveOnesIII
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, right = 0;

            int count = k;

            int length = 0;

            int maxLength = 0;

            while(right < nums.Length)
            {
                if (nums[right] == 1)
                {
                    right++;
                    length++;
                    maxLength = length > maxLength ? length : maxLength;

                    continue;
                }

                if (count > 0)
                {
                    right++;
                    count--;
                    length++;

                    maxLength = length > maxLength ? length : maxLength;

                    continue;
                }
                
                if (right + 1 == nums.Length)
                {
                    break;
                }

                if (left == right)
                {
                    left++;
                    right++;

                    continue;
                }

                if (nums[left] == 0)
                {
                    left++;

                    if (count < k) 
                    {
                        count++;
                    }

                    length--;

                    continue;
                }

                left++;
                length--;
            }

            return maxLength;
        }
    }
}
