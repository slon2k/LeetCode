using LeetCode.LeetCode150.TwoPointers;

namespace LeetCode.LeetCode150Tests.TwoPointers;

public class ThreeSumTests
{
    [Theory]
    [InlineData(new int[] {-1, 0, 1, 2, -1, -4 }, new string[] { "-1,-1,2", "-1,0,1" })]
    void ThreeSumTest(int[] nums, string[] expected )
    {
        var solution = new ThreeSum.Solution();

        var result = solution.ThreeSum(nums);

        var expectedResult = expected.Select(x => x.Split(',').Select(s => int.Parse(s))).ToList();

        Assert.Equal(expectedResult, result);
    }
}
