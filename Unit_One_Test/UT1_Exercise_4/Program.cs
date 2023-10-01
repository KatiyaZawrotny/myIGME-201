using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare strings for the three questions
            string sQuestion1 = "What is your favorite color?";
            string sQuestion2 = "What is the answer to life, the universe and everything?";
            string sQuestion3 = "What is the airspeed velocity of an unladen swallow?";
            //declare strings for the three answers
            string sAnswer1 = "black";
            string sAnswer2 = "42";
            string sAnswer3 = "What do you mean? African or European swallow?";

            //declare variable to determine if game is active
            bool bPlaying = true;
            while (bPlaying)
            {
                //ask what question number
                Console.Write("Choose your question (1-3): ");
                string sResponse = Console.ReadLine();
                switch (sResponse)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break; 
                    default:

                        break;
                }
                //start timer
                //read response
                //determine if correct
                //print right answer if wrong
                //Ask if user would like to play again
                Console.WriteLine("Play again?");
                string sPlaying = Console.ReadLine();
                if (sPlaying.StartsWith("n"))
                {
                    bPlaying = false;

                }
            }

        }
    }
}
