namespace LeetCode.LeetCode150Tests.ArrayString;

public class InsertDeleteGetRandom
{
    public class RandomizedSet
    {
        List<int> items = new();
        
        Dictionary<int, int> index = new();
        
        Random rnd = new();

        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (index.ContainsKey(val))
            {
                return false;
            }

            items.Add(val);

            index[val] = items.Count - 1;
            
            return true;
        }

        public bool Remove(int val)
        {
            if (!index.ContainsKey(val))
            {
                return false;
            }

            int itemIndex = index[val];

            int lastIndex = items.Count - 1;

            if (lastIndex != itemIndex)
            {
                Swap(itemIndex, lastIndex);
            }

            items.RemoveAt(lastIndex);

            index.Remove(val);

            return true;
        }

        private void Swap(int index1, int index2)
        {
            int item1 = items[index1];
            int item2 = items[index2];

            (items[index1], items[index2]) = (items[index2], items[index1]);
            
            index[item1] = index2;
            index[item2] = index1;
        }

        public int GetRandom()
        {
            return items.ElementAt(rnd.Next(items.Count));
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
