// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace OOP
{
    // 1. Class, Fields, Properties, Constructor, Method, Encapsulation
    public class Person
    {
        // Private field (encapsulation)
        private int _age;

        // Public properties (encapsulation)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) _age = value;
                else _age = 0;
            }
        }

        // Constructor (overloading)
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Virtual method (for polymorphism)
        public virtual void Greet()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old.");
        }
    }

    // 2. Inheritance, Method Overriding (Polymorphism)
    public class Employee : Person
    {
        public string Department { get; set; }
        public Employee(string firstName, string lastName, int age, string department)
            : base(firstName, lastName, age)
        {
            Department = department;
        }

        // Override method (runtime polymorphism)
        public override void Greet()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName}, working in {Department} department, and I'm {Age}.");
        }
    }

    // 3. Abstract Class and Method (Abstraction)
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Speak(); // Abstract method
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    // 4. Interface (Abstraction)
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }

    // 5. Static Members
    public static class MathUtils
    {
        public static double Pi = 3.14159;
        public static double Square(double x) => x * x;
    }

    // 6. Sealed Class (cannot be inherited)
    public sealed class FinalClass
    {
        public void Show() => Console.WriteLine("This is a sealed class.");
    }

    // 7. Partial Class (split across files, shown here in one file)
    public partial class PartialExample
    {
        public void Part1() => Console.WriteLine("Partial class - part 1");
    }
    public partial class PartialExample
    {
        public void Part2() => Console.WriteLine("Partial class - part 2");
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Class, Object, Constructor, Properties, Method
            Person person = new Person("John", "Doe", 30);
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
            person.Greet();

            // Inheritance, Polymorphism
            Employee emp = new Employee("Jane", "Smith", 28, "IT");
            emp.Greet();

            // Abstract class and method
            Dog dog = new Dog { Name = "Buddy" };
            dog.Speak();

            // Interface
            IMovable car = new Car();
            car.Move();

            // Static members
            Console.WriteLine($"Pi: {MathUtils.Pi}, Square(5): {MathUtils.Square(5)}");

            // Sealed class
            FinalClass finalObj = new FinalClass();
            finalObj.Show();

            // Partial class
            PartialExample partial = new PartialExample();
            partial.Part1();
            partial.Part2();

            // Object initializer
            var anotherPerson = new Person("Alice", "Wonderland", 22)
            {
                FirstName = "Alice",
                LastName = "Wonderland",
                Age = 22
            };
            anotherPerson.Greet();

            // List of base type for polymorphism
            List<Person> people = new List<Person>
            {
                new Person("Tom", "Brown", 40),
                new Employee("Sara", "Connor", 35, "HR")
            };
            foreach (var p in people)
            {
                p.Greet(); 
            }
        }
    }
}

