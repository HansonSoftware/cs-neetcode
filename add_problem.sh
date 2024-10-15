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
	echo "public class ${PROBLEM_NAME}Solver\n{\n  public void ${PROBLEM_NAME}()\n  {\n    // Your implementation here...\n    throw new ArgumentException(\"No ${PROBLEM_NAME} solution\");\n  }\n}\n"
	# Write to file
	echo "public class ${PROBLEM_NAME}Solver\n{\n  public void ${PROBLEM_NAME}()\n  {\n    // Your implementation here...\n    throw new ArgumentException(\"No ${PROBLEM_NAME} solution\");\n  }\n}\n" >> "${PROBLEM_NAME}.cs"
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
