namespace LeetCode.LeetCode150.ArrayString;

public class GasStation
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum())
            {
                return -1;
            }

            for (int i = 0; i < gas.Length; i++)
            {
                if (gas[i]> 0 && CanCompleteFrom(i, gas, cost))
                {
                    return i;
                }
            }

            return -1;
        }

        private static bool CanCompleteFrom(int index, int[] gas, int[] cost)
        {
            int fuel = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                int current = (index + i) % gas.Length;

                fuel += gas[current];

                fuel -= cost[current];

                if (fuel < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
