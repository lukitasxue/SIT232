using System;

///*
namespace MyApp
{
    internal class DoCasting
    {
        static void Main(string[] args) // // Entry point, main basic structure (main method)
        {
            int sum = 17;
            int count = 5;

            int intAverage = sum / count;
            Console.WriteLine($"The average is {intAverage}");
            // The output is 3, which is not correct, should be 3.4, but we are working with just integer divisions. The result is truncated

            double doubleAverage = sum / count;
            Console.WriteLine($"The average is {doubleAverage}");
            // The output still 3, which is not correct, because the division is still between integers.

            double correctDoubleAverage = (double)sum / count;
            Console.WriteLine($"The average is {correctDoubleAverage}");
            // the output is 3.4 which is correct, by using (double) the division is made as floating point division.
        }
    }
}
//*/