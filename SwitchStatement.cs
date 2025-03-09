//using System;

//namespace MyApp
//{
//    internal class SwitchStatements
//    {
//        static void Main(string[] args) // // Entry point, main basic structure (main method)
//        {
//            try
//            {
//                Console.WriteLine("Enter an integer: ");
//                int number = Convert.ToInt32(Console.ReadLine()); // read line is a method that reads the next line of characters from the standard input stream
                
//                switch (number)
//                {
//                    case 1:
//                        Console.WriteLine("One");
//                        break;
//                    case 2:
//                        Console.WriteLine("Two");
//                        break;
//                    case 3:
//                        Console.WriteLine("Three");
//                        break;
//                    case 4:
//                        Console.WriteLine("Four");
//                        break;
//                    case 5:
//                        Console.WriteLine("Five");
//                        break;
//                    case 6:
//                        Console.WriteLine("Six");
//                        break;
//                    case 7:
//                        Console.WriteLine("Seven");
//                        break;
//                    case 8:
//                        Console.WriteLine("Eight");
//                        break;
//                    case 9:
//                        Console.WriteLine("Nine");
//                        break;
//                    default:
//                        Console.WriteLine("Error: must enter an int between 1-9");
//                        break;
                    
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Error: Invalid input. Please enter an integer.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("An unexpected error occurred: " + ex.Message);
//            }
//        }
//    }
//}
