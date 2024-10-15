using Xunit;

namespace ValidPalindrome.Tests
{
  public class ValidPalindromeTests
  {
    [Fact]
    public void TestPalindromeWithMixedCaseAndPunctuation()
    {
      // Arrange
      ValidPalindromeSolver solver = new ValidPalindromeSolver();
      string input = "A man, a plan, a canal: Panama";

      // Act
      bool result = solver.IsPalindrome(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestNonPalindromeString()
    {
      // Arrange
      ValidPalindromeSolver solver = new ValidPalindromeSolver();
      string input = "race a car";

      // Act
      bool result = solver.IsPalindrome(input);

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestPalindromeWithEmptyString()
    {
      // Arrange
      ValidPalindromeSolver solver = new ValidPalindromeSolver();
      string input = " ";

      // Act
      bool result = solver.IsPalindrome(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestPalindromeWithOnlyNumbers()
    {
      // Arrange
      ValidPalindromeSolver solver = new ValidPalindromeSolver();
      string input = "12321";

      // Act
      bool result = solver.IsPalindrome(input);

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestPalindromeWithAlphanumericCharacters()
    {
      // Arrange
      ValidPalindromeSolver solver = new ValidPalindromeSolver();
      string input = "1A2B2a1";

      // Act
      bool result = solver.IsPalindrome(input);

      // Assert
      Assert.True(result);
    }
  }
}

