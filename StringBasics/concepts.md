## String Interpolatin:

- Dynamic string interpolation allows you to embed expressions within string literals.
- Use the `$` symbol before the string to enable interpolation.

Example:
```csharp
string name = "Alice";
int age = 30;
string greeting = $"Hello, my name is {name} and I am {age} years old.";
Console.WriteLine(greeting);
```
## String Concatenation:
- Concatenation combines multiple strings into one.
- You can use the `+` operator or the `String.Concat` method.
- Using `String.Concat` is more efficient for multiple strings.
- Example:
```csharp
string firstName = "John";
string lastName = "Doe";
string fullName = string.Concat(firstName, " ", lastName);
Console.WriteLine(fullName);
```
## String Formatting:
- String formatting allows you to create formatted strings using placeholders.
- You can use `String.Format` or interpolated strings.
- Example using `String.Format`:
```csharp
int quantity = 5;
decimal price = 19.99m;
string formattedString = String.Format("You have {0} items in your cart, each costing {1:C}.", quantity, price);
Console.WriteLine(formattedString);
```
## Trimming Strings:
- Trimming removes leading and trailing whitespace from a string.
- Use the `Trim`, `TrimStart`, or `TrimEnd` methods.
- Example:
```csharp
string paddedString = "   Hello, World!   ";
string trimmedString = paddedString.Trim();
Console.WriteLine(trimmedString); // Output: "Hello, World!"
```
