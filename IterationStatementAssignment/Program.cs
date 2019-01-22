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
            Console.WriteLine("Please enter a numeric value between 1 and 100.");
            try
            {
                string input = Console.ReadLine();
                
                while (input != "EXIT")
                {
                    int numInput = int.Parse(input);
                    int num = numInput;
                    int count = 1;

                    if ((num >=1) && (num <= 100))
                    {
                        do
                        {
                            Console.WriteLine("You have entered " + num + ". This is the current integer value in the loop: " + count);
                            count++;
                            numInput--;
                        }

                        while (numInput > 0);
                        Console.WriteLine("");
                        Console.WriteLine("Enter another numerical value if you wish. If not then type 'EXIT'.");
                        input = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(num + " is not between 1 and 100!");
                        Console.WriteLine("Try Again!");
                        input = Console.ReadLine();
                        
                    }
                }

                Environment.Exit(0);
                
            }

            catch
            {
                Console.WriteLine("A numeric value beween 1 and 100 was not given!");
            }
        }
    }
}
