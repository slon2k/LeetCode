using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class MergeSortedArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
    [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 4, 0, 0, 0, 0, 0 }, 1, new int[] { 1, 2, 3, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 5, 6 })]
    public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        var solution = new MergeSortedArray.Solution();

        solution.Merge(nums1, m, nums2, n);

        Assert.Equal(expected, nums1);
    }
}
