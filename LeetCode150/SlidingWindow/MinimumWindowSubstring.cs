namespace LeetCode.LeetCode150.SlidingWindow;

public class MinimumWindowSubstring
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return "";
            }

            int left = 0;
            int right = 0;
            string currentString = "";
            string result = "";
            int minLength = int.MaxValue;

            Dictionary<char, int> target = ToDictionary(t);
            Dictionary<char, int> current = new();

            int length = s.Length;

            while (right < length)
            {
                currentString += s[right];
                Add(current, s[right]);

                while(Contains(current, target))
                {
                    if(currentString.Length < minLength)
                    {
                        minLength = currentString.Length;
                        result = currentString;
                    }

                    left++;
                    Remove(current, currentString[0]);
                    currentString = currentString[1..];
                }

                right++;
            }

            return result;
        }

        private Dictionary<char, int> ToDictionary(string s)
        {
            Dictionary<char, int> dictionary = new();

            foreach (char c in s)
            {
                Add(dictionary, c);
            }

            return dictionary;
        }

        private void Add(Dictionary<char, int> dict, char c)
        {
            if (!dict.ContainsKey(c))
            {
                dict[c] = 1;
            } else
            {
                dict[c]++;
            }
        }

        private void Remove(Dictionary<char, int> dict, char c)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]--;

                if (dict[c] == 0)
                {
                    dict.Remove(c);
                }
            }
        }

        private bool Contains(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            foreach (var item in dict2)
            {
                if (!dict1.ContainsKey(item.Key))
                {
                    return false;
                }

                if (dict1[item.Key] < item.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
