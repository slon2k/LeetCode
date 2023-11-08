namespace LeetCode.LeetCode75;

public class DetermineCloseStrings
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            var occurrences1 = GetOccurrences(word1);

            var occurrences2 = GetOccurrences(word2);


            if (!AreEqual(occurrences1.Keys.ToArray(), occurrences2.Keys.ToArray()) || !AreEqual(occurrences1.Values.ToArray(), occurrences2.Values.ToArray())) 
            { 
                return false;
            }

            return true;

        }

        private static Dictionary<char, int> GetOccurrences(string word)
        {
            var occurrences = new Dictionary<char, int>();

            foreach (var c in word)
            {
                if (!occurrences.ContainsKey(c))
                {
                    occurrences.Add(c, 1);
                } else 
                {
                    occurrences[c]++;
                }
            }

            return occurrences;
        }

        private static bool AreEqual<T>(T[] list1, T[] list2)
        {
            if (list1.Length != list2.Length)
            {
                return false;
            }

            Array.Sort(list1);
            Array.Sort(list2);

            for (int i = 0; i < list1.Length; i++)
            {
                if (!list1[i]?.Equals(list2[i]) ?? false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
