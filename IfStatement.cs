// See https://aka.ms/new-console-template for more information




using System;

namespace MyApp
{
    internal class IfStatement
    {
        static void Main(string[] args) // // Entry point, main basic structure (main method)
        {
            try
            {
                Console.WriteLine("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine()); // read line is a method that reads the next line of characters from the standard input stream

                if (number == 1)
                {
                    Console.WriteLine("The number is one");
                }
                else if (number == 2)
                {
                    Console.WriteLine("The number is two");
                }
                else if (number == 3)
                {
                    Console.WriteLine("The number is three");
                }
                else if (number == 4)
                {
                    Console.WriteLine("The number is four");
                }
                else if (number == 5)
                {
                    Console.WriteLine("The number is five");
                }
                else if (number == 6)
                {
                    Console.WriteLine("The number is six");
                }
                else if (number == 7)
                {
                    Console.WriteLine("The number is seven");
                }
                else if (number == 8)
                {
                    Console.WriteLine("The number is eight");
                }
                else if (number == 9)
                {
                    Console.WriteLine("The number is nine");
                }
                else
                {
                    Console.WriteLine("The number is not between 1 and 9");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
