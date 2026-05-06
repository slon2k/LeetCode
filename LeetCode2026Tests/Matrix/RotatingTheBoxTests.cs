namespace LeetCode2026.Matrix.Tests;

public class RotatingTheBoxTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void RotateTheBox_ShouldRotateCorrectly(char[][] box, char[][] expected)
    {
        var rotatingTheBox = new RotatingTheBox();
        var result = rotatingTheBox.RotateTheBox(box);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new char[][] { new char[] { '#', '.', '#' } },
            new char[][]
            {
                new char[] { '.' },
                new char[] { '#' },
                new char[] { '#' }
            }
        };

        yield return new object[]
        {
            new char[][]
            {
                new char[] { '#', '.', '*', '.' },
                new char[] { '#', '#', '*', '.' }
            },
            new char[][]
            {
                new char[] { '#', '.' },
                new char[] { '#', '#' },
                new char[] { '*', '*' },
                new char[] { '.', '.' }
            }
        };

        yield return new object[]
        {
            new char[][]
            {
                new char[] { '#', '#', '*', '.', '*', '.' },
                new char[] { '#', '#', '#', '*', '.', '.' },
                new char[] { '#', '#', '#', '.', '#', '.' }
            },
            new char[][]
            {
                new char[] { '.', '#', '#' },
                new char[] { '.', '#', '#' },
                new char[] { '#', '#', '*' },
                new char[] { '#', '*', '.' },
                new char[] { '#', '.', '*' },
                new char[] { '#', '.', '.' }
            }
        };
    }
}