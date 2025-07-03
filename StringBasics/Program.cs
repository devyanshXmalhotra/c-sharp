string name = "Dev";
int age = 21;
//Interpolation example
string greeting = $"Hello, my name is {name} and I am {age} years old.";
Console.WriteLine(greeting);

//Concatenation example
string concatenatedGreeting = "Hello, my name is " + name + " and I am " + age + " years old.";
Console.WriteLine(concatenatedGreeting);

//Formatting example
string formattedGreeting = string.Format("Hello, my name is {0} and I am {1} years old.", name, age);
Console.WriteLine(formattedGreeting);

//Trimming example
string untrimmedString = "   Hello, World!   ";
string trimmedString = untrimmedString.Trim();
Console.WriteLine($"Trimmed string: '{trimmedString}'");
trimmedString = untrimmedString.TrimStart();
Console.WriteLine($"Trimmed string: '{trimmedString}'");
trimmedString = untrimmedString.TrimEnd();
Console.WriteLine($"Trimmed string: '{trimmedString}'");
