
using System;

namespace MyApp
{
    internal class Microwave
    {
        static void Main(string[] args) // // Entry point, main basic structure (main method)
        {
            Console.WriteLine("Enter number of items to heat: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a single item heating time in secs: ");
            double singleItemTime = Convert.ToDouble(Console.ReadLine());

            double recommendedTime = 0;

            if (numberOfItems == 1)
            {
                recommendedTime = singleItemTime;
            }
            else if (numberOfItems == 2)
            {
                recommendedTime = singleItemTime * 1.5; // +50%
            }
            else if (numberOfItems == 3)
            {
                recommendedTime = singleItemTime * 2; // +100%
            }
            else if (numberOfItems > 3)
            {
                Console.WriteLine("Not recommended more than 3 items.");
                return;
            }
            else
            {
                Console.WriteLine("Invalid number of items. Please enter a positive integer");
                return;
            }

            Console.WriteLine($"The recommended heating time is {recommendedTime} seconds");
        }
    }
}
