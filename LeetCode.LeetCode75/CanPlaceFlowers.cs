namespace LeetCode.LeetCode75;

public class CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var flowerbedList = new List<int> { 0 };
            flowerbedList.AddRange(flowerbed);
            flowerbedList.Add(0);

            for (int i = 1; i <= flowerbed.Length; i++)
            {
                if (flowerbedList[i] == 0 && flowerbedList[i - 1] == 0 && flowerbedList[i + 1] == 0)
                {
                    flowerbedList[i] = 1;
                    n--;
                } 
            }

            if (n > 0)
            {
                return false;
            }
            
            return true;
        }
    }
}
