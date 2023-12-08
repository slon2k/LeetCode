using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class RemoveDuplicatesIITests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 }, 5)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3, 3, 3 }, 7)]
    public void RemoveDuplicatesTest(int[] nums, int[] expected, int expectedCount)
    {
        var solution = new RemoveDuplicatesII.Solution();

        var result = solution.RemoveDuplicates(nums);

        Assert.Equal(expectedCount, result);

        Assert.Equal(expected, nums);
    }
}
