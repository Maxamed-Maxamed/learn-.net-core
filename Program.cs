// See https://aka.ms/new-console-template for more information
using System; //Imports basic functionalities (input/output).
 
namespace HelloWorldApp //Namespace is a way to organize code into logical groups.
{
    class Program //Class is a blueprint for creating objects.
    {
        static void Main(string[] args) //Main method is the entry point of the program.
        {
            Console.WriteLine("Hello, .NET Core!"); //WriteLine is a method that writes a line of text to the console.
            Console.Write("Enter your name: ");// Write is a method that writes a line of text to the console without a new line.
            string name = Console.ReadLine(); //ReadLine is a method that reads a line of text from the console.
            Console.WriteLine($"Hello, {name}!"); // $ is a string interpolation. It allows you to embed expressions inside a string.
        }
    }
}
