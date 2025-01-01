# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior and runtime errors, particularly if used in calculations or comparisons.

The `bug.cs` file shows the incorrect code; the `bugSolution.cs` file offers the corrected version.

**Problem:** Accessing `MyProperty` before assigning a value results in the default value (0 for integers) being used which might not always be expected.

**Solution:** Initialize the property either in the class declaration or in the constructor, to ensure it has a defined value before access.