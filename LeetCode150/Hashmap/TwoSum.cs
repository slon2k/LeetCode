namespace LeetCode.LeetCode150.Hashmap;

public class TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> index = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int value1 = nums[i];
                int value2 = target - value1;

                if(index.ContainsKey(value2))
                {
                    return new int[] {i, index[value2]};
                };

                index[value1] = i;
            }

            return Array.Empty<int>();
        }
    }
}
