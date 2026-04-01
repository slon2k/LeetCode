namespace LeetCode2026.BitManipulation;

// 401. Binary Watch
// A binary watch has 4 LEDs on the top which represent the hours (0-11), and the 6 LEDs on the bottom represent the minutes (0-59).
// Given an integer turnedOn which represents the number of LEDs that are currently on, return all possible times the watch could represent. The order of output does not matter.   

public class BinaryWatch
{
    public class Solution
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var times = new List<string>();

            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (CountBits(h) + CountBits(m) == turnedOn)
                    {
                        times.Add($"{h}:{m:D2}");
                    }
                }
            }

            return times;
        }

        private int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
