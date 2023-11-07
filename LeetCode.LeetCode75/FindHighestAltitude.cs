namespace LeetCode.LeetCode75;

public class FindHighestAltitude
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int height = 0;
            int maxHeight = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                height += gain[i];
                maxHeight = height > maxHeight ? height : maxHeight;                
            }

            return maxHeight;
        }
    }
}
