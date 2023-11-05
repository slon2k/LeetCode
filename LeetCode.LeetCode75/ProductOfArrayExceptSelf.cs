namespace LeetCode.LeetCode75;

public class ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;

            int[] forward = new int[length];
            int[] backwards = new int[length];
            int[] result = new int[length];

            int product = 1;

            for (int i = 0; i < length; i++)
            {
                product *= nums[i];
                forward[i] = product;
            }

            product = 1;

            for (int i = length - 1; i >= 0; i--)
            {
                product *= nums[i];
                backwards[i] = product;
            }

            for (int i = 0; i < length; i++)
            {
                result[i] = PrevProduct(forward, i) * NextProduct(backwards, i);
            }

            return result;
        }

        private int PrevProduct(int[] a, int i) => i > 0 ? a[i - 1] : 1;

        private int NextProduct(int[] a, int i) => i < a.Length - 1 ? a[i + 1] : 1;
    }
}
