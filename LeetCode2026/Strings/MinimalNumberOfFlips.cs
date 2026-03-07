namespace LeetCode2026.Strings;

// 1888. Minimum Number of Flips to Make the Binary String Alternating
// You are given a binary string s. You are allowed to perform two types of operations on the string in any sequence:
// Type-1: Remove the character at the start of the string s and append it to the end of the string.
// Type-2: Pick any character in s and flip its value, i.e., if its value is '0' it becomes '1' and vice-versa.
// Return the minimum number of type-2 operations you need to perform such that s becomes alternating.
// The string is called alternating if no two adjacent characters are equal.

public class MinimalNumberOfFlips
{
    public class Solution 
    {
        public int MinFlips(string s)
        {
            int n = s.Length, minFlips = int.MaxValue;

            var queue = new BinaryQueue();
            
            foreach (char c in s)
            {
                queue.Enqueue(c);
            }

            minFlips = Math.Min(minFlips, queue.GetFlipsToAlternating());

            for (int i = 0; i < n - 1; i++)
            {
                var c = queue.Dequeue();
                queue.Enqueue(c);

                minFlips = Math.Min(minFlips, queue.GetFlipsToAlternating());
            }

            return minFlips;
        }

        public class BinaryQueue
        {
            private Queue<int> queue = new();
            private int countOnesOdd = 0;
            private int countOnesEven = 0;

            private int countZeroesOdd = 0;
            private int countZeroesEven = 0;

            public void Enqueue(char c)
            {
                queue.Enqueue(c);

                if (c == '1')
                {
                    if (queue.Count % 2 == 0)
                    {
                        countOnesEven++;
                    }
                    else
                    {
                        countOnesOdd++;
                    }
                }
                else
                {
                    if (queue.Count % 2 == 0)
                    {
                        countZeroesEven++;
                    }
                    else
                    {
                        countZeroesOdd++;
                    }
                }
            }

            public char Dequeue()
            {
                if (queue.Count == 0) throw new InvalidOperationException("Queue is empty.");

                char c = (char)queue.Dequeue();
                if (c == '1')
                {
                    countOnesOdd--;
                }
                else
                {
                    countZeroesOdd--;
                }
                (countOnesEven, countOnesOdd) = (countOnesOdd, countOnesEven);
                (countZeroesEven, countZeroesOdd) = (countZeroesOdd, countZeroesEven);

                return c;
            }

            public int GetFlipsToAlternating()
            {
                // Calculate flips needed for both patterns: "0101..." and "1010..."
                int flipsForPattern1 = countOnesEven + countZeroesOdd; // For "0101..."
                int flipsForPattern2 = countOnesOdd + countZeroesEven; // For "1010..."

                return Math.Min(flipsForPattern1, flipsForPattern2);
            }

        }
    }
}