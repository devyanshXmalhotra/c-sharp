
// Integer types
int intValue = 42;
long longValue = 1234567890L;
short shortValue = 32000;
byte byteValue = 255;

// Floating-point types
float floatValue = 3.14f;
double doubleValue = 3.14159265359;
decimal decimalValue = 19.99m;

// Character and string
char charValue = 'A';
string stringValue = "Hello, C#!";

// Boolean
bool boolValue = true;

// Display values
Console.WriteLine($"int: {intValue}");
Console.WriteLine($"long: {longValue}");
Console.WriteLine($"short: {shortValue}");
Console.WriteLine($"byte: {byteValue}");
Console.WriteLine($"float: {floatValue}");
Console.WriteLine($"double: {doubleValue}");
Console.WriteLine($"decimal: {decimalValue}");
Console.WriteLine($"char: {charValue}");
Console.WriteLine($"string: {stringValue}");
Console.WriteLine($"bool: {boolValue}");

// Implicit casting (int to double)
double implicitCast = intValue;
Console.WriteLine($"\nImplicit cast (int to double): {implicitCast}");

// Explicit casting (double to int)
int explicitCast = (int)doubleValue;
Console.WriteLine($"Explicit cast (double to int): {explicitCast}");

// Convert class
string numberString = "100";
int parsedNumber = Convert.ToInt32(numberString);
Console.WriteLine($"Convert string to int: {parsedNumber}");

// Parsing with TryParse
string invalidNumber = "abc";
bool success = int.TryParse(invalidNumber, out int result);
Console.WriteLine($"TryParse result: {success}, value: {result}");

// Boxing and unboxing
object boxed = intValue; // Boxing
int unboxed = (int)boxed; // Unboxing
Console.WriteLine($"Boxed int: {boxed}, Unboxed int: {unboxed}");
  