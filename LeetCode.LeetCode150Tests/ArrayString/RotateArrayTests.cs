using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;
public class RotateArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { -1 }, 2, new int[] { -1 })]
    public void Rotate(int[] nums, int k, int[] expected)
    {
        var solution = new RotateArray.Solution();

        solution.Rotate(nums, k);

        Assert.Equal(expected, nums);
    }
}
