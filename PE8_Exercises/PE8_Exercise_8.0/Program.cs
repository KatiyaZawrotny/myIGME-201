using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Exercise_8._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            //convert
            string result = Replace(input, "no", "yes");

            //print     
            Console.WriteLine(result);
        }

        static string Replace(string input, string original, string change)
        {
            input = input.ToLower();
            original = original.ToLower();

            return input.Replace(original, change);
        }

    }
}
