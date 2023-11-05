using System.Text;

namespace LeetCode.LeetCode75;

public class GreatestCommonDivisorOfStrings
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            var divisors1 = GetDivisors(str1);
            var divisors2 = GetDivisors(str2);

            var commonDivisors = new List<string>();

            foreach (var divisor in divisors1)
            {
                if (divisors2.Contains(divisor))
                {
                    commonDivisors.Add(divisor);
                }
            }

            if (commonDivisors.Count > 0)
            {
                return commonDivisors.Last();
            }

            return "";
        }

        private bool IsDivisor(string div, string str)
        {
            if (div.Length == 0)
            {
                return false;
            }

            int n = str.Length / div.Length;

            if (n == 0 || n * div.Length != str.Length)
            {
                return false;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(div);
            }

            if (sb.ToString() == str) 
            {
                return true;
            }

            return false;
        }

        private List<string> GetDivisors(string str)
        {
            int i = 0;
            string div = "";
            List<string> divisors = new List<string>();

            while (i < str.Length)
            {
                div += str[i++];

                if (IsDivisor(div, str))
                {
                    divisors.Add(div);
                }
            }

            return divisors;
        }
    }
}
