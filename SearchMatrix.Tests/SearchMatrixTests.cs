using Xunit;

namespace SearchMatrix.Tests
{
  public class SearchMatrixTests
  {
    [Fact]
    public void TestSearchMatrixWithTargetPresent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
      }, 3);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestSearchMatrixWithTargetAbsent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
      }, 13);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestSearchMatrixWithSingleRowAndTargetPresent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 1, 3, 5, 7 }
      }, 5);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestSearchMatrixWithSingleRowAndTargetAbsent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 1, 3, 5, 7 }
      }, 6);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestSearchMatrixWithEmptyMatrix()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][] { }, 1);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestSearchMatrixWithSingleElementMatrixTargetPresent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 42 }
      }, 42);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestSearchMatrixWithSingleElementMatrixTargetAbsent()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { 42 }
      }, 10);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestSearchMatrixWithNegativeNumbers()
    {
      // Arrange
      var solver = new SearchMatrixSolver();

      // Act
      var result = solver.SearchMatrix(new int[][]
      {
                new int[] { -10, -5, -2, -1 },
                new int[] { 0, 1, 3, 5 },
                new int[] { 7, 8, 10, 12 }
      }, -5);

      // Assert
      Assert.True(result);
    }
  }
}
