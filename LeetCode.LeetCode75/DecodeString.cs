namespace LeetCode.LeetCode75;

public class DecodeString
{
    public class Solution
    {
        public string DecodeString(string s)
        {
            var stringsStack = new Stack<string>();
            var numbersStack = new Stack<int>();

            int currentNumber = 0;
            string currentString = "";

            foreach (var c in s)
            {
                if (c == '[')
                {
                    stringsStack.Push(currentString);
                    numbersStack.Push(currentNumber);
                    currentNumber = 0;
                    currentString = "";
                }
                else if (IsLetter(c))
                {
                    currentString += c;
                }
                else if (IsDigit(c))
                {
                    currentNumber *= 10;
                    currentNumber += ToNumber(c);
                }
                else if (c == ']')
                {
                    currentString = stringsStack.Pop() + Repeat(currentString, numbersStack.Pop());
                }
            }

            return currentString;
        }

        private string Repeat(string s, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += s;
        }

            return result;
        }

        private static bool IsDigit(char c) => c >= '0' && c <= '9';

        private static bool IsLetter(char c) => c >= 'a' && c <= 'z';

        private static int ToNumber(char c) => c - '0';
    }
}
