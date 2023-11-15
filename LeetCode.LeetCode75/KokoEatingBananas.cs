namespace LeetCode.LeetCode75;

public class KokoEatingBananas
{
    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            long left = 1;
            long right = int.MaxValue;

            if (Hours(piles, left) <= h)
            {
                return 1;
            }

            while (left < right - 1)
            {
                long middle = left + (right - left)/2;

                if (Hours(piles, middle) > h)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return (int)left + 1;
        }

        private long Hours(int[] piles, long speed)
        {
            return piles.Select(x => x / speed + (x % speed > 0 ? 1 : 0)).Sum();
        }
    }
}
