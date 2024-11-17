using Xunit;

namespace MaxProfit.Tests
{
  public class MaxProfitTests
  {
    [Fact]
    public void TestMaxProfitWithStandardInput()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { 10, 1, 5, 6, 7, 1 });

      // Assert
      Assert.Equal(6, result);
    }

    [Fact]
    public void TestMaxProfitWithDecreasingPrices()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { 7, 6, 4, 3, 1 });

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void TestMaxProfitWithIncreasingPrices()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { 1, 2, 3, 4, 5 });

      // Assert
      Assert.Equal(4, result);
    }

    [Fact]
    public void TestMaxProfitWithSinglePrice()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { 5 });

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void TestMaxProfitWithEmptyPrices()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { });

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void TestMaxProfitWithLargeNumbers()
    {
      // Arrange
      var solver = new MaxProfitSolver();

      // Act
      var result = solver.MaxProfit(new int[] { 1000000, 1, 10000000 });

      // Assert
      Assert.Equal(9999999, result);
    }
  }
}
