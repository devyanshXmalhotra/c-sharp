// See https://aka.ms/new-console-template for more information


int[] numbers = { 10, 20, 30, 40, 50, 60 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (var num in numbers)
{
    Console.WriteLine(num);
}

int first = numbers[0];
int last = numbers[^1];
Console.WriteLine($"First: {first}, Last: {last}");

int[] slice = numbers[2..5];
foreach (var n in slice)
{
    Console.WriteLine(n);
}