namespace LeetCode.LeetCode150.Hashmap;

public class ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dictionary = new Dictionary();

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];

                if (dictionary.Contains(current))
                {
                    return true;
                }

                dictionary.Add(current);

                if (i - k >= 0)
                {
                    dictionary.Remove(nums[i - k]);
                }
            }

            return false;
        }

        private class Dictionary
        {
            private readonly Dictionary<int, int> dictionary;
            
            public Dictionary() 
            {
                dictionary = new Dictionary<int, int>();
            }
            
            public void Add(int x)
            {
                if (!dictionary.ContainsKey(x))
                {
                    dictionary[x] = 1;
                }
                else
                {
                    dictionary[x]++;
                }
            }

            public void Remove(int x)
            {
                if (dictionary.ContainsKey(x))
                {
                    dictionary[x]--;
                }

                if (dictionary[x] == 0)
                {
                    dictionary.Remove(x);
                }
            }

            public bool Contains(int x) => dictionary.ContainsKey(x);

            public int Count => dictionary.Count;
        }
    }
}
