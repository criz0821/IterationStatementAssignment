/*
    Author: Christopher Mejia
    Date: 1/24/2019
    Comment: This is my iteration statement assignment for a number between 1 and 100
 */
using System;

namespace IterationStatementAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter an integer
            Console.WriteLine("Please enter a numeric value between 1 and 100.");
            try
            {
                // reading input from user
                string input = Console.ReadLine();
                
                // creating while loop to enbale consecutive inputs
                while (input != "EXIT")
                {
                    // establishing variables for user input and count
                    int numInput = int.Parse(input);
                    int num = numInput;
                    int count = 1;

                    // validating user input (between 1 and 100)
                    if ((num >=1) && (num <= 100))
                    {
                        do
                        {
                            Console.WriteLine("You have entered " + num + ". This is the current integer value in the loop: " + count);
                            count++;
                            numInput--;
                        } // end of do

                        while (numInput > 0);
                        Console.WriteLine("");
                        Console.WriteLine("Enter another numerical value if you wish. If not then type 'EXIT'.");
                        input = Console.ReadLine();
                    } // end of if 

                    // if user didn't enter a vlue between 1 and 100, the else statement runs
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(num + " is not between 1 and 100!");
                        Console.WriteLine("Try Again!");
                        input = Console.ReadLine();
                        
                    } // end of else

                } // end of while

                // when the user types 'EXIT' instead of Console.Readkey(true), this will close application instantly
                Environment.Exit(0);
                
            } // end of try

            // if there was an error in the try block this code will run
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("A numeric value beween 1 and 100 was not given!");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            } // end of catch
        } // end of main
    } // end of class
} // end of namespace
