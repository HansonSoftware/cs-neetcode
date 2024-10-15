using Xunit;

namespace EncodeDecodeStrings.Tests
{
  public class EncodeDecodeStringsTests
  {
    [Fact]
    public void TestEncodeDecodeWithStandardInput()
    {
      // Arrange
      EncodeDecodeStringsSolver solver = new EncodeDecodeStringsSolver();
      var input = new List<string> { "neet", "code", "love", "you" };

      // Act
      string encoded = solver.Encode(input);
      var result = solver.Decode(encoded);

      // Assert
      Assert.Equal(input, result);
    }

    [Fact]
    public void TestEncodeDecodeWithSymbolsAndSingleCharacters()
    {
      // Arrange
      EncodeDecodeStringsSolver solver = new EncodeDecodeStringsSolver();
      var input = new List<string> { "we", "say", ":", "yes" };

      // Act
      string encoded = solver.Encode(input);
      var result = solver.Decode(encoded);

      // Assert
      Assert.Equal(input, result);
    }

    [Fact]
    public void TestEncodeDecodeWithEmptyStrings()
    {
      // Arrange
      EncodeDecodeStringsSolver solver = new EncodeDecodeStringsSolver();
      var input = new List<string> { "", "empty", "", "strings" };

      // Act
      string encoded = solver.Encode(input);
      var result = solver.Decode(encoded);

      // Assert
      Assert.Equal(input, result);
    }
  }
}

