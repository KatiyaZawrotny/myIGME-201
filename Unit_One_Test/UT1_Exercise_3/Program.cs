using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Exercise_3
{
    internal class Program
    {
        //declare delegate
        delegate double RoundImpersonation(double value, int places);

        //Prints a rounded version of a number using a delegate method.
        static void Main(string[] args)
        {
            //instantiate delegate
            RoundImpersonation round = Math.Round;
            //call delegate and assign to result variable
            double dFinalValue = round(2.83333, 2);
            //print
            Console.WriteLine(dFinalValue);
        }
    }
}
