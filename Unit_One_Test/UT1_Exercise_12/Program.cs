using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            //It should prompt for the user's name
            Console.Write("What is your name? -> ");
            sName = Console.ReadLine();
            //then call the following function:
            bool bGotRaise = GiveRaise(sName, ref dSalary);

            //The main program should congratulate the user if they got a raise, and display their new salary.
            if (bGotRaise)
            {
                Console.WriteLine($"Congratulations on getting a raise, {sName}! Your new salary is {dSalary}.");
            }
            else
            {
                Console.WriteLine("Sorry, but you did not get a raise.");
            }
            

        }
        static bool GiveRaise(string name, ref double salary)
        {
            //The function should increase the salary by $19,999.99 if name = your name and return true
            if (name.Equals("Katiya"))
            {
                salary += 19999.99;
                return true;
            }
            //Otherwise it should return false.
            return false;
        }
    }
}
