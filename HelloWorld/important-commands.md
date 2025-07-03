# .NET Console App: Important Commands & Startup Syntax

## Initialization Commands

1. Create a new console project:
   dotnet new console -n HelloWorld

2. Navigate to project directory:
   cd HelloWorld

3. Restore dependencies:
   dotnet restore

4. Build the project:
   dotnet build

5. Run the project:
   dotnet run

## Basic Startup Syntax (Program.cs)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

## Additional Useful Commands

- List installed SDKs:
  dotnet --list-sdks

- List installed runtimes:
  dotnet --list-runtimes

- Add a NuGet package:
  dotnet add package <PackageName>

- Publish the app:
  dotnet publish -c Release -o ./publish
