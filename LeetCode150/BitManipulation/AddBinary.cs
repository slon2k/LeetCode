using System.Text;

namespace LeetCode.LeetCode150.BitManipulation;

public class AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int extra = 0;

            int length = Math.Max(a.Length, b.Length);

            a = Reverse(a);
            b = Reverse(b);

            var sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int x = GetDigit(a, i);
                int y = GetDigit(b, i);
                int sum = x + y + extra;

                sb.Append(sum % 2);

                extra = sum / 2;
            }

            if (extra == 1)
            {
                sb.Append(extra);
            }

            return Reverse(sb.ToString());
        }

        private int GetDigit(string s, int index) => index < s.Length ? ToInt(s[index]) : 0;

        private static string Reverse(string s) => new(s.Reverse().ToArray());

        private int ToInt(char c) => c - '0';
    }
}
