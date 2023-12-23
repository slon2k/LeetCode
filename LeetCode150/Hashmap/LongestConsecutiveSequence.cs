namespace LeetCode.LeetCode150.Hashmap;

public class LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new SortedSet<int>(nums);

            int count = 1;
            int maxCount = 0;

            int current = int.MaxValue; 

            foreach (int number in set)
            {
                if (number - 1 == current)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                maxCount = count > maxCount ? count : maxCount;
                current = number;
            }

            return maxCount;
        }
    }
}
