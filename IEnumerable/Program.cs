// See https://aka.ms/new-console-template for more information


using System;

List<int> scores = [ 90, 80, 70, 60, 50, 40, 30, 20, 10 ];

Console.WriteLine($"Score count:{scores.Count}");

IEnumerable<int> score = from n in scores orderby n select n;

foreach(int n in score)
{
    Console.WriteLine(n);
}

IEnumerable<int> scoreQuery = from n in scores where n < 40 select n;

foreach (int n in scoreQuery)
{
    Console.WriteLine(n);
}