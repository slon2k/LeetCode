namespace LeetCode.LeetCode150.ArrayString;

public class RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            
            char prev = '#';

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char letter = s[i];

                int value = ToInt(letter);

                if ("IXC".Contains(letter) && ToInt(prev) > ToInt(letter))
                {
                   value *= -1;
                }

                result += value;

                prev = letter;
            }

            return result;
        }

        private int ToInt(char c) => c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}
