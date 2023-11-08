namespace LeetCode.LeetCode75;

public class DecodeString
{
    public class Solution
    {
        public string DecodeString(string s)
        {
            throw new NotImplementedException();
        }


        private static bool IsDigit(char c) => c >= '0' && c <= '9';

        private static bool IsLetter(char c) => c >= 'a' && c <= 'z';

        private static int ToNumber(char c) => c - '0';
    }
}
