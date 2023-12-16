namespace LeetCode.LeetCode150.TwoPointers;

public class TwoSumSortedInputArray
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = Find(numbers, i + 1, numbers.Length - 1, target - numbers[i]);

                if (index != -1)
                {
                    return new int[] { i + 1, index + 1 };
                }
            }

            return new int[] {};
        }

        private int Find(int[] numbers, int first, int last, int target)
        {
            if (numbers[first] > target || numbers[last] < target)
            {
                return -1;
            }
            
            if (numbers[first] == target)
            {
                return first;
            }

            if (numbers[last] == target)
            {
                return last;
            }

            while (first < last - 1)
            {
                int middle = first + (last - first) / 2;

                if (numbers[middle] == target)
                {
                    return middle;
                }

                if (numbers[middle] > target)
                {
                    last = middle;
                } else
                {
                    first = middle;
                }
            }

            return -1;
        }
    }
}
