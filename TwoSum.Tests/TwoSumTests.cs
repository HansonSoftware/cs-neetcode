namespace TwoSum.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void TestTwoSum()
        {
            var solver = new TwoSumSolver();
            var result = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}
