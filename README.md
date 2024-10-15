# TDD C# Environment for Solving Leetcode Locally

## Problems with Tests:

### Arrays & Hashing:

1. Two Sum
2. Valid Anagram
3. Encode and Decode Strings

### Two Pointers:

4. Valid Palindrome

### Stack:

5. Valid Parentheses

### Binary Search:

6. Binary Search
7. Search a 2D Matrix

### Sliding Window

8. Best Time to Buy & Sell Stock

### Linked List:

9. LRU Cache

### Tree:

10. Invert Binary Tree
11. Serialize & Deserialize Binary Tree

### Heap / Priority Queue:

12. Task Scheduler
13. Kth Largest Element in a Stream

### Greedy:

14. Maximum Subarray

### Graph:

15. Course Schedule

### Dynamic Programming:

16. Climbing Stairs
17. LCS (Longest Common Subsequence)

### Bit Manipulation:

18. Single Number
19. Missing Number
20. Sum of Two Integers (no + or - operator)

[Blogpost](https://www.haydenhanson.dev/blog/test-driven-c-sharp)

## How to use this repo:

## MacOS Specific Instructions

### 1.1 Install the DOTNET sdk

#### How? With Homebrew.

If you don't have homebrew, install it. It's a great package manager for MacOS.

```sh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
```

Go through the cli and press enter when prompted, you will need XCode command line tools, so be sure to accept when the homebrew cli asks.

If you are using an Apple silicon macbook, add `brew` to your PATH like so.

```sh
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> ~/.zprofile
eval "$(/opt/homebrew/bin/brew shellenv)"
```

**Now we're ready to install the .NET sdk.**

```sh
brew install --cask dotnet-sdk
```

## Linux Specific Instructions

### 1.1 Install the DOTNET sdk

Install `dotnet` with your distros package manager.

I use Arch Linux, so I'll install it using pacman.

```sh
sudo pacman -S dotnet-runtime dotnet-sdk
```

## The rest of the instructions are for both Linux and MacOS

### 1.2 Create a Git Repository

**Note:** If you're just here to get started right away, clone this repository from this commit. There are 20 problems set up with unit tests written. You can solve the problems and test your code as you go. _More info on testing at the bottom._

#### For those following along:

I'm going to call mine cs-neetcode.

```sh
mkdir cs-neetcode && cd cs-neetcode

git init
touch .gitignore
echo "bin/\nobj/" >> .gitignore
```

This will create your local repository, and add the bin and obj directories to the gitignore.

### 1.3 Modular File System

The repository will look like this after we're finished:

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

There will be a unique directory for each problem you want to solve.

**Create a dotnet project and a solution file:**

> Run this command from the root directory of the repository.

```sh
dotnet new console -n cs-neetcode

dotnet new sln -n cs-neetcode
```

### 1.4 Preparing Solution Directories

#### Before using these commands, read this entire section. There is a useful sh script at the end that will automate this process.

For each problem, create a new class library and a corresponding test project.

Example for TwoSum:

```sh
dotnet new classlib -n TwoSum -o TwoSum
dotnet new xunit -n TwoSum.Tests -o TwoSum.Tests
```

Add the projects to the `solution`

**You will do this for each new leetcode problem you solve**

```sh
dotnet sln add TwoSum/TwoSum.csproj
dotnet sln add TwoSum.Tests/TwoSum.Tests.csproj
```

Link the test project to the problem project so that the tests can reference the solution.

```sh
dotnet add TwoSum.Tests/TwoSum.Tests.csproj reference TwoSum/TwoSum.csproj
```

**I have automated this process with the following shell script:**

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

Be sure to make add_problem.sh executable:

```sh
chmod +x add_problem.sh
```

### 1.5 Writing Tests and C# Code

The script above generates a testing file that will look similar to this:

**TwoSum.Tests/TwoSumTests.cs**

```cs
namespace TwoSum.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void TestTwoSum()
        {
            var solver = new TwoSumSolver();
            var result = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
    }
}
```

**TwoSum/TwoSum.cs**

```cs
public class TwoSumSolver
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Store the difference from target and its index
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if (numDict.ContainsKey(difference))
            {
                return new int[] { numDict[difference], i };
            }

            if (!numDict.ContainsKey(nums[i]))
            {
                numDict.Add(nums[i], i);
            }
        }

        throw new ArgumentException("No two sum solution");
    }
}
```

### 1.6 Running Tests

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

**_Happy Coding!_**
