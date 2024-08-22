using Xunit;
using ValidAnagram; // Ensure this namespace matches your class library namespace

namespace ValidAnagram.Tests
{
    public class SolutionTests
    {
        private readonly Solution _solution;

        public SolutionTests()
        {
            _solution = new Solution();
        }

        [Fact]
        public void TestValidAnagram_Anagrams_ReturnsTrue()
        {
            string s = "anagram";
            string t = "nagaram";
            bool result = _solution.IsAnagram(s, t);
            Assert.True(result);
        }

        [Fact]
        public void TestValidAnagram_NotAnagrams_ReturnsFalse()
        {
            string s = "rat";
            string t = "car";
            bool result = _solution.IsAnagram(s, t);
            Assert.False(result);
        }

        [Fact]
        public void TestValidAnagram_EmptyStrings_ReturnsTrue()
        {
            string s = "";
            string t = "";
            bool result = _solution.IsAnagram(s, t);
            Assert.True(result);
        }

        [Fact]
        public void TestValidAnagram_DifferentLengths_ReturnsFalse()
        {
            string s = "hello";
            string t = "helloo";
            bool result = _solution.IsAnagram(s, t);
            Assert.False(result);
        }

        [Fact]
        public void TestValidAnagram_SingleCharacterAnagrams_ReturnsTrue()
        {
            string s = "a";
            string t = "a";
            bool result = _solution.IsAnagram(s, t);
            Assert.True(result);
        }

        [Fact]
        public void TestValidAnagram_SingleCharacterNotAnagrams_ReturnsFalse()
        {
            string s = "a";
            string t = "b";
            bool result = _solution.IsAnagram(s, t);
            Assert.False(result);
        }
    }
}

