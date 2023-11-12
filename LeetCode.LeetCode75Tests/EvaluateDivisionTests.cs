using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class EvaluateDivisionTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "a,b","b,c" }, new double[] { 2.0, 3.0 }, new string[] { "a,c","b,a","a,e","a,a","x,x"}, new double[] { 6.00000, 0.50000, -1.00000, 1.00000, -1.00000 })]
        [InlineData(new string[] { "a,b","b,c", "bc,cd" }, new double[] { 1.5, 2.5, 5.0 }, new string[] { "a,c","c,b","bc,cd","cd,bc" }, new double[] { 3.75000, 0.40000, 5.00000, 0.20000 })]
        [InlineData(new string[] { "a,b" }, new double[] { 0.5 }, new string[] { "a,b","b,a","a,c","x,y" }, new double[] { 0.50000, 2.00000, -1.00000, -1.00000 })]
        public void CalcEquation(string[] equations, double[] values, string[] queries, double[] expected)
        {
            var solution = new EvaluateDivision.Solution();

            IList<IList<string>> equationList = new List<IList<string>>();
            
            foreach (var equation in equations)
            {
                IList<string> items = equation.Split(',').ToList();
                equationList.Add(items);
            }

            IList<IList<string>> queriesList = new List<IList<string>>();
            
            foreach (var query in queries)
            {
                IList<string> items = query.Split(',').ToList();
                queriesList.Add(items);
            }

            var result = solution.CalcEquation(equationList, values, queriesList);
            
            Assert.Equal(expected, result);
        }
    }
}
