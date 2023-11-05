using System.Text;

namespace LeetCode.LeetCode75;

public class StringCompression
{
    public class Solution
    {
        public int Compress(char[] chars)
        {
            int length = chars.Length;

            if (length == 0)
            {
                return 0;
            }

            var sb = new StringBuilder();

            int count = 1;

            char prevChar = chars[0];

            sb.Append(prevChar);

            for (int i = 1; i < length; i++)
            {
                if (chars[i] == prevChar)
                {
                    count++;
                } 
                else
                {
                    if (count > 1)
                    {
                        sb.Append(count);
                    }
                                       
                    sb.Append(chars[i]);
                    count = 1; 
                    prevChar = chars[i];
                }
            }

            if (count > 1)
            {
                sb.Append(count);
            }

            string resultString = sb.ToString(); 

            for (int i = 0; i < resultString.Length; i++)
            {
                chars[i] = resultString[i];
            }

            return resultString.Length;
        }
    }
}
