public class TwoSumSolver
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store the difference and its corresponding index
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the difference needed to reach the target
            int difference = target - nums[i];

            // Check if the difference is already in the dictionary
            if (numDict.ContainsKey(difference))
            {
                // If found, return the indices of the current number and the difference
                return new int[] { numDict[difference], i };
            }

            // If not found, add the current number and its index to the dictionary
            if (!numDict.ContainsKey(nums[i]))
            {
                numDict.Add(nums[i], i);
            }
        }

        // If no solution is found, throw an exception (as per LeetCode's requirements)
        throw new ArgumentException("No two sum solution");
    }
}
