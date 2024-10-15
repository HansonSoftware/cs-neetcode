# Test Driven C# Environment for Solving Leetcode Locally

## How to use this repo:

- Use branch [clean](https://github.com/HansonSoftware/cs-neetcode/tree/clean) for starting fresh and using the included script to create your own problems.

- Use branch [base](https://github.com/HansonSoftware/cs-neetcode/tree/base) to start solving the problems provided

  - Run `dotnet test` from the root directory to test the whole project
  - Run `cd {PROBLEM_NAME} && dotnet test` to test a problem individually
  - Write your solutions in `{PROBLEM_NAME}/{PROBLEM_NAME}.cs`
  - Add more tests in `{PROBLEM_NAME}.Tests/{PROBLEM_NAME}Tests.cs`

- The [main](https://github.com/HansonSoftware/cs-neetcode/tree/main) branch includes all of my solutions.

_Note:_ I created a [blogpost](https://www.haydenhanson.dev/blog/test-driven-c-sharp) about how I made this repo and give instructions on how you can create one too.

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

Be sure to make [add_problem.sh](https://github.com/HansonSoftware/cs-neetcode/blob/main/add_problem.sh) executable:

```sh
chmod +x add_problem.sh
```

Run it with `./add_problem.sh`

Input your leetcode problems name.

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
