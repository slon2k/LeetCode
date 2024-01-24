namespace LeetCode.LeetCode150.Backtracking;

public class Permutations
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            return Permute(nums.ToList());
        }

        private IList<IList<int>> Permute(IList<int> numbers)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (numbers.Count == 1)
            {
                result.Add(new List<int>() { numbers[0] });

                return result;
            }
            
            foreach (int number in numbers)
            {
                HashSet<int> set = new(numbers);
                
                set.Remove(number);

                var permutations = Permute(set.ToList());

                foreach (var permutation in permutations)
                {
                    permutation.Add(number);
                    result.Add(permutation);
                }
            }

            return result;
        }
    }
}
