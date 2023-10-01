using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Exercise_12
{
    internal class Program
    {
        struct Employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            //Initialize employee info
            Employee employee = new Employee();
            employee.dSalary = 30000;

            //It should prompt for the user's name
            Console.Write("What is your name? -> ");

            //update employee with new info (name)
            employee.sName = Console.ReadLine();

            //then call the following function:
            bool bGotRaise = GiveRaise(ref employee);

            //The main program should congratulate the user if they got a raise, and display their new salary.
            if (bGotRaise)
            {
                Console.WriteLine($"Congratulations on getting a raise, {employee.sName}! Your new salary is {employee.dSalary}.");
            }
            else
            {
                Console.WriteLine("Sorry, but you did not get a raise.");
            }


        }
        static bool GiveRaise(ref Employee employee)
        {
            //The function should increase the salary by $19,999.99 if name = your name and return true
            if (employee.sName.Equals("Katiya"))
            {
                employee.dSalary += 19999.99;
                return true;
            }
            //Otherwise it should return false.
            return false;
        }
    }
}
