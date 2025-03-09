using System;

namespace MyApp
{
    internal class Sandbox
    {
        static void Main(string[] args) // Entry point, main basic structure (main method)
        {
            // Q3 problem 1
            Console.WriteLine("Question 3, Problem 1 fixed code");
            int number = 50;
            if (number == 50) ;
            {
                Console.WriteLine("Number is" + number);
            }

            // problem 2
            Console.WriteLine("Problem 2 fixed code");
            number = 60;
            if (number >= 50 && number <= 100) {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
            }

            // problem 3
            Console.WriteLine("Problem 3 fixed code");
            Score.CheckScore();

            // problem 4
            Console.WriteLine("Problem 4 fixed code");
            int n = 3; 

            switch (n)  
            {
                case 1:
                    Console.WriteLine("The number is 1"); 
                    break; 

                case 2:
                    Console.WriteLine("The number is 2");
                    break; 

                default:
                    Console.WriteLine("The number is not 1 or 2");
                    break; 
            }

            // problem 5
            Console.WriteLine("Problem 5 fixed code");
            n = 1;

            switch(n)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }

            // Q4 problem 1:
            Console.WriteLine("Question 4 Problem 1 wrong output");
            int height = 12;
            if (height <= 12)
                Console.WriteLine("Low bridge: ");
                Console.WriteLine("proceed with caution.");

            // fix:
            Console.WriteLine("Problem 1 fixed output");
            if (height <= 12)
            {
                Console.WriteLine("Low bridge: ");
                Console.WriteLine("proceed with caution.");
            }

            // problem 2:
            Console.WriteLine("Problem 2 wrong output");
            int sum = 20;
            if (sum != 20)
                Console.WriteLine("You win ");
            else
                Console.WriteLine("You lose ");
            Console.WriteLine("the prize.");

            // fix:
            Console.WriteLine("Problem 2 fixed output");
            sum = 21;
            if (sum != 20)
            {
                Console.WriteLine("You win ");
                Console.WriteLine("the prize.");
            }
            else
            {
                Console.WriteLine("You lose ");
                Console.WriteLine("the prize.");
            }

            // problem 3:
            Console.WriteLine("Problem 3 wrong output");
            sum = 7;
            if (sum > 20)
            {
                Console.WriteLine("You win ");
            }
            else
            {
                Console.WriteLine("You lose ");
            }
            Console.WriteLine("the prize.");

            //fix
            Console.WriteLine("Problem 3 fixed output");
            sum = 7;
            if (sum > 20)
            {
                Console.WriteLine("You win ");
                Console.WriteLine("the prize.");
            }
            else
            {
                Console.WriteLine("You lose ");
                Console.WriteLine("the prize.");
            }



        }
    }

    // problem 3 
    public class Score
    {
        //public static void Main(string[] args)
        public static void CheckScore()
        {
            double score = 40;
            if (score > 40)
            {
                Console.WriteLine("You passed the exam!");
            }
            else if (score < 40)
            {
                Console.WriteLine("You failed the exam!");
            }
            else
            {
                Console.WriteLine("You passed the exam!"); // in case of exactly 40
            }
        }
    }
}
