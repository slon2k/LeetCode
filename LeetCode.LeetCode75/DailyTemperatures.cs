using System.Linq;

namespace LeetCode.LeetCode75;

public class DailyTemperatures
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int length = temperatures.Length;

            var results = new Dictionary<int, int>[length + 1];

            int[] answer = new int[length];

            results[length] = new();

            for (int i = length - 1; i >= 0; i--)
            {
                results[i] = new Dictionary<int, int>(results[i + 1])
                {
                    [temperatures[i]] = i
                };
            }

            for (int i = 0; i < length; i++)
            {
                var index = results[i].Where(r => r.Key > temperatures[i]).Select(r => r.Value).DefaultIfEmpty().Min();

                if (index > 0)
                {
                    answer[i] = index - i;
                }
            }

            return answer;
        }
    }
}
