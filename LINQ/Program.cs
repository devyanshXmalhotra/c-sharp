// See https://aka.ms/new-console-template for more information

int[] numbers = { 10, 20, 30, 40, 50, 60 };

// Filtering
var filtered = numbers.Where(n => n > 30);
Console.WriteLine("Filtered (n > 30):");
foreach (var n in filtered)
    Console.WriteLine(n);

// Projection
var squares = numbers.Select(n => n * n);
Console.WriteLine("Squares:");
foreach (var n in squares)
    Console.WriteLine(n);

// Ordering
var descending = numbers.OrderByDescending(n => n);
Console.WriteLine("Descending order:");
foreach (var n in descending)
    Console.WriteLine(n);

// Aggregation
int sum = numbers.Sum();
double avg = numbers.Average();
int min = numbers.Min();
int max = numbers.Max();
Console.WriteLine($"Sum: {sum}, Average: {avg}, Min: {min}, Max: {max}");

// First and Last
int first = numbers.First();
int last = numbers.Last();
Console.WriteLine($"First: {first}, Last: {last}");

// Any and All
bool anyAbove50 = numbers.Any(n => n > 50);
bool allAbove5 = numbers.All(n => n > 5);
Console.WriteLine($"Any > 50: {anyAbove50}, All > 5: {allAbove5}");

// Take and Skip
var firstThree = numbers.Take(3);
var skipTwo = numbers.Skip(2);
Console.WriteLine("First three:");
foreach (var n in firstThree)
    Console.WriteLine(n);
Console.WriteLine("Skip two:");
foreach (var n in skipTwo)
    Console.WriteLine(n);

// Distinct 
int[] numsWithDuplicates = { 10, 20, 20, 30, 30, 30, 40 };
var distinctNums = numsWithDuplicates.Distinct();
Console.WriteLine("Distinct values:");
foreach (var n in distinctNums)
    Console.WriteLine(n);

// Grouping 
var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
foreach (var group in groups)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
}