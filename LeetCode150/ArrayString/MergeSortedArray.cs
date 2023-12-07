namespace LeetCode.LeetCode150.ArrayString;

public class MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            for (int i = 0; i < m; i++)
            {
                int k = n + m - 1 - i;
                nums1[k] = nums1[k - n];
            }


            int left = n;
            int right = 0;

            int current = 0;

            while (current < n + m)
            {
                if (left > m + n - 1)
                {
                    nums1[current++] = nums2[right++];
                    continue;
                }

                if (right >= n)
                {
                    nums1[current++] = nums1[left++];
                    continue;
                }

                if (nums1[left] <= nums2[right])
                {
                    nums1[current++] = nums1[left++];
                }
                else
                {
                    nums1[current++] = nums2[right++];
                }
            }
        }
    }
}
