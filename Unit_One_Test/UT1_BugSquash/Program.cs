﻿using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY --Syntax error, needs semicolon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); -- syntax error. needs quotes
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); -- logic error. need to assign input to a variable
                sNumber = Console.ReadLine(); 
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY)); //changed nX to nY, added bang op

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine($"{nX}^{nY} = {nAnswer}"); //added $ for interpolation
        }


        static int Power(int nBase, int nExponent) // added static keyword
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 1; // changed base case to 1 and not 0 because x^0 = 1
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent - 1); // changed + 1 to -1 so function is not infinite

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            return returnVal; // added return statement
        }
    }
}
