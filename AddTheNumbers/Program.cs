using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTheNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing variables
            int result = 0;
            //loops 4 times to ask for user input and adds the ints to the result
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Enter your #{0} number: ", i);
                int numberVar = Convert.ToInt32(Console.ReadLine());
                result += numberVar;
            }
            //Relays the sum of the 4 numbers
            Console.WriteLine("Your sum is {0}", result);
        }
    }
}
