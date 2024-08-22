using Xunit;
using ContainsDuplicate;

namespace ContainsDuplicate.Tests
{
    public class SolutionTests
    {
        private readonly Solution _solution;

        public SolutionTests()
        {
            _solution = new Solution();
        }

        [Fact]
        public void TestContainsDuplicate_WithDuplicates_ReturnsTrue()
        {
            int[] nums = { 1, 2, 3, 4, 5, 1 };
            bool result = _solution.ContainsDuplicate(nums);
            Assert.True(result);
        }

        [Fact]
        public void TestContainsDuplicate_NoDuplicates_ReturnsFalse()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            bool result = _solution.ContainsDuplicate(nums);
            Assert.False(result);
        }

        [Fact]
        public void TestContainsDuplicate_EmptyArray_ReturnsFalse()
        {
            int[] nums = { };
            bool result = _solution.ContainsDuplicate(nums);
            Assert.False(result);
        }

        [Fact]
        public void TestContainsDuplicate_SingleElementArray_ReturnsFalse()
        {
            int[] nums = { 1 };
            bool result = _solution.ContainsDuplicate(nums);
            Assert.False(result);
        }

        [Fact]
        public void TestContainsDuplicate_AllElementsSame_ReturnsTrue()
        {
            int[] nums = { 2, 2, 2, 2 };
            bool result = _solution.ContainsDuplicate(nums);
            Assert.True(result);
        }
    }
}

