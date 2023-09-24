using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Exercise_3
{
    internal class Program
    {
        //delegate declaration 
        delegate string ReadLine();
      
        //main calls a delegate method to read a line from the user.
        static void Main(string[] args)
        {
            //declare delegate method variable
            ReadLine myRead;
            myRead = new ReadLine(Read);

            //calling the delegate method
            Console.WriteLine("Enter a string: ");
            string output = myRead();
            Console.WriteLine(output);
        }
        static string Read()
        {
            return Console.ReadLine();
        }
    }
}
