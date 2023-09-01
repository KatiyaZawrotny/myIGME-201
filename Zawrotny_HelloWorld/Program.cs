            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zawrotny_HelloWorld
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            //prints a message to the console. My name!!
            Console.WriteLine("Katiya Zawrotny");

            //playing with addition, variables, and string concatenation
            int x = 2;
            int y = 3;
            int sum;
            sum = 2 + 3;
            Console.WriteLine(x + "+" + y + " = " + sum);

            //playing with loops
            Console.WriteLine("Watch this! I can count to the sum!!");
            for (int i = 1; i <= sum; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
