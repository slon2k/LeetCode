namespace LeetCode.LeetCode150.TwoPointers;

public class ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            HashSet<(int, int, int)> answers = new();

            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    int first = nums[i];
                    int second = nums[j];
                    int target = -second - first;

                    int index = Find(target, nums, j + 1, nums.Length - 1);

                    if (index >= 0)
                    {
                        answers.Add((first, second, target));                      
                    }
                }
            }

            foreach (var answer in answers)
            {
                result.Add(new List<int> { answer.Item1, answer.Item2, answer.Item3 });
            }

            return result;
        }

        private int Find(int target, int[] nums, int left, int right)
        {
            if (nums[left] > target || nums[right] < target)
            {
                return -1;
            }

            if (nums[left] == target)
            {
                return left;
            }

            if (nums[right] == target)
            {
                return right;
            }

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }

                if (nums[middle] > target)
                {
                     right = middle;
                }
                else
                {
                   left = middle;
                }
            }

            return -1;
        }
    }
}
