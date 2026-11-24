using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Multiple Calculations: Loop keeps the calculator running
            while (true)
            {
                Console.WriteLine("\n=== C# Calculator ===");
                Console.WriteLine("Choose an operation (+, -, *, /) or type 'Q' to quit:");
                string operation = Console.ReadLine()?.Trim().ToUpper();

                if (operation == "Q")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                // 4. User Experience: Validate the operator before asking for numbers
                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid operator. Please enter +, -, *, /, or Q.");
                    continue;
                }

                // 1. Input Validation: Using double.TryParse() instead of Convert.ToDouble()
                double num1 = ReadValidNumber("Enter the first number: ");
                double num2 = ReadValidNumber("Enter the second number: ");

                // 2. Code Reusability: Calling separate methods for each operation
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {num1} + {num2} = {Add(num1, num2)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {num1} - {num2} = {Subtract(num1, num2)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {num1} * {num2} = {Multiply(num1, num2)}");
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        else
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {Divide(num1, num2)}");
                        }
                        break;
                }
            }
        }

        // Helper method for safe input validation & better UX
        static double ReadValidNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                Console.WriteLine("Invalid number! Please enter a valid numeric value (e.g., 12.5).");
            }
        }

        // Individual methods for each mathematical operation
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;
    }
}
