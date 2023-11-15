namespace LeetCode.LeetCode75;

public class SuccessfulPairsSpellsPotions
{
    public class Solution
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);

            return spells.Select(s => BinarySearch(s, potions, success)).ToArray();
        }

        private int BinarySearch( int value, int[] source, long success)
        {
            int length = source.Length;

            if (source[length - 1] * value < success) 
            {
                return 0;
            }

            if (source[0] * value >= success)
            {
                return length;
            }

            int left = 0;
            int right = length - 1;

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;

                if (source[middle] * value < success)
                {
                    left = middle;
                } else
                {
                    right = middle;
                }
            }

            return length - 1 - left;
        } 

    }
}
