using LeetCode2026.Strings;

namespace LeetCode2026Tests.Strings
{
	public class StringToIntegerAtoiTests
	{
		[Theory]
		[InlineData("42", 42)]
		[InlineData("   -42", -42)]
        [InlineData(" 042", 42)]
        [InlineData(" -042", -42)]
		[InlineData("4193 with words", 4193)]
		[InlineData("words and 987", 0)]
		[InlineData("-91283472332", -2147483648)] // underflow
		[InlineData("91283472332", 2147483647)] // overflow
		[InlineData("+1", 1)]
		[InlineData("0000123", 123)]
		[InlineData("", 0)]
		[InlineData("   +0 123", 0)]
		[InlineData("-+12", 0)]
		[InlineData("+", 0)]
		[InlineData("-", 0)]
		public void MyAtoi_ReturnsExpected(string input, int expected)
		{
			var solution = new Solution();
			var result = solution.MyAtoi(input);
			Assert.Equal(expected, result);
		}
	}
}
