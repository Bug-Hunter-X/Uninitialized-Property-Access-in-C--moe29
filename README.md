# Uninitialized Property Access in C#

This repository demonstrates a subtle issue in C# related to accessing uninitialized properties. While accessing an uninitialized property yields the default value for its type, attempting to modify it before assignment throws an exception. This behavior can be unexpected for developers unfamiliar with this nuance.

## Bug

The `Bug.cs` file showcases the problematic code.  Accessing the `MyProperty` before assigning a value prints 0. Attempting to increment it (as commented out in the code) leads to a runtime error. 

## Solution

The `BugSolution.cs` file provides a corrected version, demonstrating the proper way to handle property initialization to avoid unexpected behavior and exceptions.