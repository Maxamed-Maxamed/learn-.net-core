using System; // Import the System namespace

namespace CalculatorApp // Define a namespace for the CalculatorApp
{
    class Program // Define a class named Program
    {
        static void Main(string[] args) // Define a static void Main method
        {
            Console.Write("Enter first number: "); // Prompt the user to enter the first number
            double num1 = Convert.ToDouble(Console.ReadLine()); // Read the user's input and convert it to a double

            Console.Write("Enter an operator (+, -, *, /): "); // Prompt the user to enter an operator
            char op = Console.ReadKey().KeyChar; /// Read the user's input and store it in a char variable
            Console.WriteLine(); // Print a newline character to move to the next line

            Console.Write("Enter second number: "); // Prompt the user to enter the second number
            double num2 = Convert.ToDouble(Console.ReadLine()); // Read the user's input and convert it to a double
            double result = 0; // Initialize a variable to store the result
            switch (op) // Use a switch statement to perform the selected operation
            {
                case '+': // If the user entered '+', add the two numbers 
                    result = num1 + num2; 
                    break;
                case '-': // If the user entered '-', subtract the two numbers
                    result = num1 - num2;
                    break;
                case '*':  // If the user entered '*', multiply the two numbers
                    result = num1 * num2;
                    break;
                case '/':  // If the user entered '/', divide the two numbers
                    result = num2 != 0 ? num1 / num2 : 0;
                    break;
                default: // If the user entered an invalid operator, print an error message and exit the program
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}"); // Print the result  of the calculation
        }
    }
}
