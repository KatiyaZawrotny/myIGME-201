using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.Write("Enter a string to have it reversed: ");
            string forward = Console.ReadLine();

            //intialize array to hold backwards version
            char[] backwardsArray = new char[forward.Length];

            //loop through the string and assign it to the array in reverse order
            for (int i = 0; i < forward.Length; i++)
            {
                backwardsArray[i] = forward[forward.Length - i-1];
            }

            //make the array a string
            string backwards = string.Join("", backwardsArray);

            //print string
            Console.WriteLine(backwards);
        }
    }
}
