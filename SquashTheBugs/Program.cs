using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            // Line does not end in a semicolon. Variable "i" is later unnecessarily reassigned. Moved "i"
            // declaration to the loop and renamed this variable to "counter"

            int counter = 0;
            string allNumbers = null;
            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)
            //Loop will only occur 9 times, we need i to be less than or equal to 10 in order to get *through* 10
            for (int i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;
                //this line needs to be declared outside of the loop.

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                //Line was missing parentheses
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                if ((i-1)!= 0)
                {
                    Console.WriteLine(i / (i - 1));
                }
                else
                {
                    Console.WriteLine("Divide by zero!!");
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1;
                //i is increased by the loop, so changed to the counter variable we made outside the loop

                counter++;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

