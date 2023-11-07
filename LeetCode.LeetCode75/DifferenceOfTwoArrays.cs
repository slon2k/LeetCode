namespace LeetCode.LeetCode75;

public class DifferenceOfTwoArrays
{
    public class Solution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var list1 = set1.Where(x => !set2.Contains(x)).ToList();
            var list2 = set2.Where(x => !set1.Contains(x)).ToList();

            IList<IList<int>> result = new List<IList<int>>
            {
                list1,
                list2
            };

            return result;
        }
    }
}
