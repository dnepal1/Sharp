using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# program in Visual Studio Code!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Please enter a number for age: ");
            }

            Console.WriteLine($"\nHello {name}, you are {age} years old.");
        }
    }
}
