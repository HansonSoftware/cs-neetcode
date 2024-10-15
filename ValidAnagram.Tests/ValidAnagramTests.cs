using Xunit;

namespace ValidAnagram.Tests
{
  public class ValidAnagramTests
  {
    [Fact]
    public void TestValidAnagram()
    {
      // Arrange
      ValidAnagramSolver solver = new ValidAnagramSolver();

      // Act
      bool result = solver.IsAnagram("anagram", "nagaram");

      // Assert
      Assert.True(result);
    }

    [Fact]
    public void TestNotAnAnagram()
    {
      // Arrange
      ValidAnagramSolver solver = new ValidAnagramSolver();

      // Act
      bool result = solver.IsAnagram("rat", "car");

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestAnagramWithDifferentLengths()
    {
      // Arrange
      ValidAnagramSolver solver = new ValidAnagramSolver();

      // Act
      bool result = solver.IsAnagram("hello", "helloo");

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestAnagramWithSameLettersDifferentFrequency()
    {
      // Arrange
      ValidAnagramSolver solver = new ValidAnagramSolver();

      // Act
      bool result = solver.IsAnagram("aabbcc", "abc");

      // Assert
      Assert.False(result);
    }

    [Fact]
    public void TestAnagramWithSpecialCharacters()
    {
      // Arrange
      ValidAnagramSolver solver = new ValidAnagramSolver();

      // Act
      bool result = solver.IsAnagram("a!b@c#", "c@b!a#");

      // Assert
      Assert.True(result);
    }
  }
}

