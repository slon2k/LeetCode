using LeetCode2026.Mathematics;

namespace LeetCode2026Tests.Mathematics
{
	public class ReverseIntegerTests
	{
		[Theory]
		[InlineData(123, 321)]
		[InlineData(-123, -321)]
		[InlineData(120, 21)]
		[InlineData(0, 0)]
		[InlineData(2147483642, 0)] // overflow case
        [InlineData(-2147483642, 0)] // overflow case
		public void Reverse_ReturnsExpected(int input, int expected)
		{
			var solution = new Solution();
			var result = solution.Reverse(input);
			Assert.Equal(expected, result);
		}
	}
}
