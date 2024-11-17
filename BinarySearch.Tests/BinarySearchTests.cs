using Xunit;

namespace BinarySearch.Tests
{
  public class BinarySearchTests
  {
    [Fact]
    public void TestBinarySearchWithTargetPresent()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 9);

      // Assert
      Assert.Equal(4, result);
    }

    [Fact]
    public void TestBinarySearchWithTargetAbsent()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { -1, 0, 3, 5, 9, 12 }, 2);

      // Assert
      Assert.Equal(-1, result);
    }

    [Fact]
    public void TestBinarySearchWithSingleElementArray()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { 5 }, 5);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void TestBinarySearchWithEmptyArray()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { }, 3);

      // Assert
      Assert.Equal(-1, result);
    }

    [Fact]
    public void TestBinarySearchWithNegativeNumbers()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { -10, -5, -2, -1 }, -5);

      // Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void TestBinarySearchWithTargetAtStart()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 1);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void TestBinarySearchWithTargetAtEnd()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 5);

      // Assert
      Assert.Equal(4, result);
    }

    [Fact]
    public void TestBinarySearchWithDuplicates()
    {
      // Arrange
      var solver = new BinarySearchSolver();

      // Act
      int result = solver.BinarySearch(new int[] { 1, 2, 2, 2, 3 }, 2);

      // Assert
      Assert.Equal(1, result); // First occurrence or any valid index
    }
  }
}
