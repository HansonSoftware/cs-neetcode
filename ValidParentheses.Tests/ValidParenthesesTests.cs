using Xunit;

namespace ValidParentheses.Tests
{
  public class ValidParenthesesTests
  {
    [Fact]
    public void TestValidParenthesesWithSinglePair()
    {
      // Arrange
      ValidParenthesesSolver solver = new ValidParenthesesSolver();
      string input = "()";

      // Act
      bool result = solver.IsValid(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestValidParenthesesWithMultiplePairs()
    {
      // Arrange
      ValidParenthesesSolver solver = new ValidParenthesesSolver();
      string input = "()[]{}";

      // Act
      bool result = solver.IsValid(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestInvalidParenthesesWithDifferentTypes()
    {
      // Arrange
      ValidParenthesesSolver solver = new ValidParenthesesSolver();
      string input = "(]";

      // Act
      bool result = solver.IsValid(input);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestValidNestedParentheses()
    {
      // Arrange
      ValidParenthesesSolver solver = new ValidParenthesesSolver();
      string input = "([])";

      // Act
      bool result = solver.IsValid(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestInvalidOrderOfParentheses()
    {
      // Arrange
      ValidParenthesesSolver solver = new ValidParenthesesSolver();
      string input = "([)]";

      // Act
      bool result = solver.IsValid(input);

      // Assert
      Assert.False(result);
    }
  }
}

