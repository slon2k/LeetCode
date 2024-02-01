using LeetCode.LeetCode150.BinaryTree;

namespace LeetCode.LeetCode150.DivideAndConquer;

internal class ArrayToBST
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateNode(nums, 0, nums.Length - 1);
        }

        private static TreeNode? CreateNode(int[] nums, int start, int end)
        {
            if (end < start || start > end)
            {
                return null;
            }

            if (end == start)
            {
                return new TreeNode(nums[start]);
            }

            int middle = start + (end - start) / 2;

            return new TreeNode(nums[middle])
            {
                left = CreateNode(nums, start, middle - 1),

                right = CreateNode(nums, middle + 1, end)
            };
        }
    }
}
