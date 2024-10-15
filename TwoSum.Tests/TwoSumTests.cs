using Xunit;

namespace TwoSum.Tests
{
  public class TwoSumTests
  {
    [Fact]
    public void TestTwoSumWithStandardInput()
    {
      // Arrange
      TwoSumSolver solver = new TwoSumSolver();

      // Act
      var result = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

      // Assert
      Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TestTwoSumWithMultipleValidPairs()
    {
      // Arrange
      TwoSumSolver solver = new TwoSumSolver();

      // Act
      var result = solver.TwoSum(new int[] { 3, 2, 4 }, 6);

      // Assert
      Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void TestTwoSumWithDuplicateNumbers()
    {
      // Arrange
      TwoSumSolver solver = new TwoSumSolver();

      // Act
      var result = solver.TwoSum(new int[] { 3, 3 }, 6);

      // Assert
      Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TestTwoSumWithNegativeNumbers()
    {
      // Arrange
      TwoSumSolver solver = new TwoSumSolver();

      // Act
      var result = solver.TwoSum(new int[] { -1, -2, -3, -4 }, -6);

      // Assert
      Assert.Equal(new int[] { 1, 3 }, result);
    }

    [Fact]
    public void TestTwoSumWithLargeNumbers()
    {
      // Arrange
      TwoSumSolver solver = new TwoSumSolver();

      // Act
      var result = solver.TwoSum(new int[] { 1000000, 500, 1000000 }, 2000000);

      // Assert
      Assert.Equal(new int[] { 0, 2 }, result);
    }
  }
}

