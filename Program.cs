/*
    Author: Jared Krachenfels
    Class: ISM 3400 Fall 2020
    Date: 9/13/2020
    Assignment: Tech Project #2b
 */
using System;

namespace TechProj_2b_JKrachenfels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Request user input
            Console.WriteLine("Please enter the grade you expect to get in ISM 3400:");

            // Try-catch can be used to validate the user's input. 
            // If input is not acceptable, catch block will handle error.
            try
            {
                // Variable to gather user input
                string input = Console.ReadLine();
               
                // Grade variable will be used to store grade after input variable is parsed to dec.
                int grade = int.Parse(input);

                // If/else statement to test the input. Depending on the input, various options for Grade (A,B,C,D,F)
                // If statement executes for any integar less than or equal to 59
                if (grade <= 59)
                {
                    Console.WriteLine("Your letter grade in ISM 3400 will unfortunately be an F. There is rarely an excuse for a grade like this.");
                }
                // else if statement executes for any integer between 60 and 69.
                else if ((grade<=69) && (grade >= 60))
                {
                    Console.WriteLine("Your letter grade in ISM 3400 will unfortunately be a D. You didn't quite meet expectations. Make sure to pay attention in class and participate in assignments");
                }
                // else if statement executes for any integer between 70 and 79
                else if ((grade <= 79) && (grade >= 70))
                {
                    Console.WriteLine("Your letter grade in ISM 3400 will be a C. You barely met expectations, but I'd like to see you perfrom a bit higher.");
                }
                // else if statement executes for any integer between 80 and 89
                else if ((grade <= 89) && (grade >= 80))
                {
                    Console.WriteLine("Your letter grade in ISM 3400 will be a B. You met expectations! Good job!");
                }
                // else statement executes for any other integer (which is any integer over or equal to 90)
                else
                {
                    Console.WriteLine("CONGRATULATIONS! Your letter grade in ISM 3400 will be an A. You exceeded all expectations! Great Job!");
                }
            } // End of try
            catch
            {
                // If user does not enter an integer
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // end of catch
        } // end of main
    } // end of class
} // end of namespace
