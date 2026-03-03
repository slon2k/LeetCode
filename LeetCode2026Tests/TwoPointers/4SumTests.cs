using LeetCode2026.TwoPointers;

namespace LeetCode2026Tests.TwoPointers
{
    public class FourSumTests
    {
        [Theory]
        [InlineData(new int[] {1, 0, -1, 0, -2, 2}, 0, new int[] {
            -2, -1, 1, 2,
            -2, 0, 0, 2,
            -1, 0, 0, 1
        })]
        [InlineData(new int[] {2, 2, 2, 2, 2}, 8, new int[] {
            2, 2, 2, 2
        })]
        public void FourSum_ReturnsExpected(int[] nums, int target, int[] expectedFlat)
        {
            var solution = new FourSum.Solution();
            var result = solution.FourSum(nums, target);
            var expected = ToQuadruplets(expectedFlat);
            Assert.Equal(
                [.. ToStringSets(expected)],
                new HashSet<string>(ToStringSets(result))
            );
        }

        private List<IList<int>> ToQuadruplets(int[] flat)
        {
            var quadruplets = new List<IList<int>>();
            for (int i = 0; i < flat.Length; i += 4)
            {
                var quad = new List<int>();
                for (int j = 0; j < 4 && i + j < flat.Length; j++)
                    quad.Add(flat[i + j]);
                quadruplets.Add(quad);
            }
            return quadruplets;
        }

        private IEnumerable<string> ToStringSets(IEnumerable<IList<int>> lists)
        {
            foreach (var list in lists)
            {
                yield return string.Join(",", list);
            }
        }
    }
}
