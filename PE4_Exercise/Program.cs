using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;
            bool validInput = false;
            Console.WriteLine("Enter two numbers. Only one can be greater than 10.");

            while (!validInput)
            {

                Console.WriteLine("First number:");
                var1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number:");
                var2 = int.Parse(Console.ReadLine());

                if (var1 <= 10 || var2 <= 10)
                {
                    Console.WriteLine("Success");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Failed. Both numbers greater than 10");
                }


            }


        }
    }
}
