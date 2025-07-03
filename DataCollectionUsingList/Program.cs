// See https://aka.ms/new-console-template for more information
//var=local variable type inference


var names= new List<string> {"anuj", "sachin", "priyanka", "sanjay", "suman"};

foreach(var name in names)
{
    Console.WriteLine(name);
}

names.Add("sumanth");
names.Add("sumanth2");

for (int i=0;i<names.Count;i++)
{
    Console.WriteLine(names[i]);
}

names.Remove("sumanth2");

foreach (var name in names)
{
    Console.WriteLine(name);
}
