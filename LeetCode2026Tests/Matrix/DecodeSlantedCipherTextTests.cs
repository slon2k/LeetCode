using LeetCode2026.Matrix;

namespace LeetCode2026Tests.Matrix;

public class DecodeSlantedCipherTextTests
{
    [Theory]
    [InlineData("ch   ie   pr", 3, "cipher")]
    [InlineData("iveo    eed   l te   olc", 4, "i love leetcode")]
    [InlineData("coding", 1, "coding")]
    public void DecodeSlantedCipherTextTest(string encodedText, int rows, string expected)
    {
        var sut = new DecodeSlantedCipherText();
        var actual = sut.DecodeCiphertext(encodedText, rows);
        Assert.Equal(expected, actual);
    }
}