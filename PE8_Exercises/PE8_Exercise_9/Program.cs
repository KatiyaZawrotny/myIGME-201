using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is my string";

            string[] words = testString.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                result += "\"" + word + "\"" + " ";
            }
            Console.WriteLine(result);
        }
    }
}
