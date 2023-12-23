namespace LeetCode.LeetCode150.Hashmap;

public class HappyNumber
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> visited = new();

            while(n != 1)
            {
                if (visited.Contains(n))
                {
                    return false;
                }

                visited.Add(n);

                n = GetNext(n);
            }

            return true;
        }
    
        private static IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                yield return digit;
            }
        }

        private static int GetNext(int number) => GetDigits(number).Select(x => x * x).Sum();    
    
    }
}
