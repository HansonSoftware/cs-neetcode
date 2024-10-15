# Test Driven C# Environment for Solving Leetcode Locally

## LC Problems with Tests in this repository:

### Arrays & Hashing:

1. Two Sum [LC #1](https://leetcode.com/problems/two-sum/description/)
2. Valid Anagram [LC #242](https://leetcode.com/problems/valid-anagram/description/)
3. Encode and Decode Strings [LC #271](https://neetcode.io/problems/string-encode-and-decode)

### Two Pointers:

4. Valid Palindrome [LC #125](https://leetcode.com/problems/valid-palindrome/description/)

### Stack:

5. Valid Parentheses [LC #20](https://leetcode.com/problems/valid-parentheses/description/)

### Binary Search:

6. Binary Search [LC #704](https://leetcode.com/problems/binary-search/description/)
7. Search a 2D Matrix [LC #74](https://leetcode.com/problems/search-a-2d-matrix/description/)

### Sliding Window

8. Best Time to Buy & Sell Stock [LC #121](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/)

### Linked List:

9. LRU Cache [LC #146](https://leetcode.com/problems/lru-cache/description/)

### Tree:

10. Invert Binary Tree [LC #226](https://leetcode.com/problems/invert-binary-tree/description/)
11. Serialize & Deserialize Binary Tree [LC #297](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/description/)

### Heap / Priority Queue:

12. Task Scheduler [LC #621](https://leetcode.com/problems/task-scheduler/description/)
13. Kth Largest Element in a Stream [LC #703](https://leetcode.com/problems/kth-largest-element-in-a-stream/description/)

### Greedy:

14. Maximum Subarray [LC #53](https://leetcode.com/problems/maximum-subarray/description/)

### Graph:

15. Course Schedule [LC #207](https://leetcode.com/problems/course-schedule/description/)

### Dynamic Programming:

16. Climbing Stairs [LC #70](https://leetcode.com/problems/climbing-stairs/description/)
17. LCS (Longest Common Subsequence) [LC #1143](https://leetcode.com/problems/longest-common-subsequence/description/)

### Bit Manipulation:

18. Single Number [LC #136](https://leetcode.com/problems/single-number/description/)
19. Missing Number [LC #268](https://leetcode.com/problems/missing-number/description/)
20. Sum of Two Integers (no + or - operator) [LC #371](https://leetcode.com/problems/sum-of-two-integers/description/)

## How to use this repo:

- Use (branch clean) for starting fresh and using the included script to create your own problems.

- Use (branch starting-point) to start solving the problems provided

  - Run `dotnet test` from the root directory to test the whole project
  - Run `cd {PROBLEM_NAME} && dotnet test` to test a problem individually
  - Write your solutions in `{PROBLEM_NAME}/{PROBLEM_NAME}.cs`
  - Add more tests in `{PROBLEM_NAME}.Tests/{PROBLEM_NAME}Tests.cs`

- The main branch includes all of my solutions.

_Note:_ I created a [blogpost](https://www.haydenhanson.dev/blog/test-driven-c-sharp) about how I made this repo and give instructions on how you can create one too.

### File Structure:

```sh
cs-neetcode/
│
├── TwoSum/
│   ├── TwoSum.cs
│   └── TwoSumTests.cs
│
├── ValidAnagram/
│   ├── ValidAnagram.cs
│   └── ValidAnagramTests.cs
│
├── Etc.../
│
├── cs-neetcode.sln
└── .gitignore
```

### Included Script:

Be sure to make add_problem.sh executable:

```sh
chmod +x add_problem.sh
```

**add_problem.sh**

```sh
#!/bin/sh

# Run this script from the root directory of your dotnet project.

###########################################
# Add new problem to solve to the project #
###########################################

# Get the problem name
echo "Enter the problem name (e.g., TwoSum):"
read PROBLEM_NAME

# Create the class library project
echo "Creating new classlib for $PROBLEM_NAME..."
dotnet new classlib -n "$PROBLEM_NAME" -o "$PROBLEM_NAME"
echo "New classlib created for $PROBLEM_NAME."

# Create the xUnit test project
echo "Creating new xunit for $PROBLEM_NAME..."
dotnet new xunit -n "$PROBLEM_NAME.Tests" -o "$PROBLEM_NAME.Tests"
echo "New xunit created for $PROBLEM_NAME."

# Add projects to the solution
echo "Adding the projects to the root sln..."
dotnet sln add "$PROBLEM_NAME/$PROBLEM_NAME.csproj"
dotnet sln add "$PROBLEM_NAME.Tests/$PROBLEM_NAME.Tests.csproj"
echo "Successfully added the projects to the root sln."

# Add reference from the test project to the class library project
echo "Adding a reference for xunit to the classlib..."
dotnet add "${PROBLEM_NAME}.Tests/${PROBLEM_NAME}.Tests.csproj" reference "$PROBLEM_NAME/$PROBLEM_NAME.csproj"
echo "Successfully added a reference for xunit to the classlib..."

################################################
# Populate the default files with problem name #
################################################

# REFACTORING CLASSLIB FILES
echo "Refactoring the classlib files..."
cd $PROBLEM_NAME

defaultFile="$(find Class1.cs)"

if [ "$defaultFile" = "Class1.cs" ]; then
	# Remove the default file generated
	rm $defaultFile

	# Create new file and populate
	touch "$PROBLEM_NAME.cs"

	# Preview to terminal
	echo "public class ${PROBLEM_NAME}Solver\n{\n  public void ${PROBLEM_NAME}()\n  {\n    // Your implementation here...\n    throw new ArgumentException(\"No ContainsDuplicate solution\");\n  }\n}\n"
	# Write to file
	echo "public class ${PROBLEM_NAME}Solver\n{\n  public void ${PROBLEM_NAME}()\n  {\n    // Your implementation here...\n    throw new ArgumentException(\"No ContainsDuplicate solution\");\n  }\n}\n" >> "${PROBLEM_NAME}.cs"
fi

echo "Done."

# REFACTORING TESTING FILES
echo "Refactoring the xunit files..."

cd "../${PROBLEM_NAME}.Tests"

PROBLEM_NAME_TESTS="${PROBLEM_NAME}Tests"

defaultTestFile="$(find UnitTest1.cs)"

if [ "$defaultTestFile" = "UnitTest1.cs" ]; then
	# Remove the default file generated
	rm $defaultTestFile

	# Create new file and populate
	touch "${PROBLEM_NAME_TESTS}.cs"

	# Preview to terminal
	echo "using Xunit;\n\nnamespace ${PROBLEM_NAME}.Tests\n{\n  public class ${PROBLEM_NAME_TESTS}\n  {\n    [Fact]\n    public void Test${PROBLEM_NAME}()\n    {\n    }\n  }\n}\n"
	# Write to file
	echo "using Xunit;\n\nnamespace ${PROBLEM_NAME}.Tests\n{\n  public class ${PROBLEM_NAME_TESTS}\n  {\n    [Fact]\n    public void Test${PROBLEM_NAME}()\n    {\n    }\n  }\n}\n" >> "${PROBLEM_NAME_TESTS}.cs"
fi

echo "Done."

# Return back to the root directory
cd ".."

# Exit script gracefully
echo "Setup complete. Solution '$PROBLEM_NAME.sln' created with projects '$PROBLEM_NAME' and '${PROBLEM_NAME}.Tests'."
```

### Testing:

You can test the entire repository by running the following command from the root directory of the project.

```sh
dotnet test
```

To test an individual leetcode solution, run the same command from the corresponding directory.

For example:

**TwoSum.Tests/**

```sh
cd TwoSum.Tests

dotnet test
```

![dotnet test](https://www.haydenhanson.dev/images/posts/test-driven-c-sharp/example.png)
