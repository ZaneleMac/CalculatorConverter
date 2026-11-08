using System;
class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("------Welcome to the Calculator Converter Application!----");
            Console.WriteLine("1. Perform Calculation, basic Math (+, -, *,/");
            Console.WriteLine("2. Convert Kilometer to Miles");
            Console.WriteLine("3. Celsius to Fahrenheit");
            Console.WriteLine("4. GHS to USD Currency");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter first number: ");
                if (double.TryParse(Console.ReadLine(), out double num1)) {
                    Console.Write("Enter operator (+, -, *, /): ");
                    string op = Console.ReadLine();
                    Console.Write("Enter second number: ");
                    if (double.TryParse(Console.ReadLine(), out double num2))
                    {
                        if (op == "+")
                        {
                            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        }
                        else if (op == "-")
                        {
                            Console.Write($"Result: {num2} - {num1} = {num2 - num1} ");
                        }
                        else if (op == "*")
                        {
                            Console.Write($"Result: {num1} * {num2} = {num1 * num2} ");
                        }
                        else if (op == "/")
                        {
                            if (num2 != 0)
                            {
                                Console.Write($"Result: {num2} / {num1} = {num2 / num1} ");

                            } else
                            {
                                Console.WriteLine("Error: Cannot be dividedg by zero");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error:Invalid second number");
                    }

                }
                else
                {
                    Console.WriteLine("Error: Invalid first number");
                }
            }
            else if(choice == "2")
            {
                Console.Write("Enter Kilometers: ");
                if (double.TryParse(Console.ReadLine(), out double km))
                {
                    double miles = km * 0.621371;
                    Console.WriteLine($"{km} km = {miles:F2} miles");
                }
                else { Console.WriteLine("Invalid input "); }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter Celsius: ");
                if (double.TryParse(Console.ReadLine(), out double c))
                {
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine($"{c}  °C = {f:F2} °F");
                }
                else { Console.WriteLine("Invalid input"); }
            }
            else if (choice == "4")
            {
                Console.Write("Enter amount in GHS: ");
                if (double.TryParse(Console.ReadLine(), out double ghs))
                {
                    Console.Write("Enter exchange rate (1 GHS to USD): ");
                    if (double.TryParse(Console.ReadLine(), out double rate))
                    {
                        double usd = ghs / rate;
                        Console.WriteLine($"{ghs} GHS = ${usd:F2} USD");
                    }
                    else { Console.WriteLine("Invalid rate."); }
                }
                else { Console.WriteLine("Invalid amount."); }
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Exiting program. Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
