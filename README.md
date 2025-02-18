# C# DivideByZeroException
This repository demonstrates a common error in C#: the DivideByZeroException. The `bug.cs` file shows the problematic code, and the `bugSolution.cs` provides a corrected version.

## Bug Description
The original code attempts to divide an integer by zero, leading to a `DivideByZeroException` at runtime.  This exception is thrown when you perform a division operation where the divisor (the number you're dividing by) is zero.

## Solution
The solution involves adding a check to prevent division by zero.  This can be done using an `if` statement to verify that the divisor is not zero before performing the division.  Alternatively, the `??` operator is used for a more compact solution. 

This demonstrates proper error handling and preventing runtime exceptions that can crash applications.