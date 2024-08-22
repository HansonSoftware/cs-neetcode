#!/bin/sh

#####################################
# Run this script from cs-neetcode/ #
#####################################

# Get the problem name
echo "Enter the problem name (e.g., TwoSum):"
read PROBLEM_NAME

# Create the class library project
dotnet new classlib -n "$PROBLEM_NAME" -o "$PROBLEM_NAME"

# Create the xUnit test project
dotnet new xunit -n "${PROBLEM_NAME}.Tests" -o "${PROBLEM_NAME}.Tests"

# Add projects to the solution
dotnet sln add "$PROBLEM_NAME/$PROBLEM_NAME.csproj"
dotnet sln add "${PROBLEM_NAME}.Tests/${PROBLEM_NAME}.Tests.csproj"

# Add reference from the test project to the class library project
dotnet add "${PROBLEM_NAME}.Tests/${PROBLEM_NAME}.Tests.csproj" reference "$PROBLEM_NAME/$PROBLEM_NAME.csproj"

echo "Setup complete. Solution '$PROBLEM_NAME.sln' created with projects '$PROBLEM_NAME' and '${PROBLEM_NAME}.Tests'."
