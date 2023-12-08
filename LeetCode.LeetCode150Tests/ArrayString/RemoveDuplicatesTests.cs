using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class RemoveDuplicatesTests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2, 2 }, 2)]
    public void RemoveDuplicatesTest(int[] nums, int[] expected, int expectedCount)
    {
        var solution = new RemoveDuplicates.Solution();

        var result = solution.RemoveDuplicates(nums);

        Assert.Equal(expectedCount, result);

        Assert.Equal(expected, nums);
    }
}
