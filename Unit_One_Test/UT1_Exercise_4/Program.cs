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

            //declare chosen question/answer variables
            string sQuestion;
            string sAnswer;

            //declare variable to determine if game is active
            bool bPlaying = true;
            
            while (bPlaying)
            {
                //ask what question number
                bool bValid = false;
                while (!bValid)
                {
                    Console.Write("Choose your question (1-3): ");
                    string sResponse = Console.ReadLine();
                    //assign the chosen question + answer to the active question+answer variables.
                    switch (sResponse)
                    {
                        case "1":
                            sQuestion = sQuestion1;
                            sAnswer = sAnswer1;
                            bValid = true;
                            break;
                        case "2":
                            sQuestion = sQuestion2;
                            sAnswer = sAnswer2;
                            bValid = true;
                            break;
                        case "3":
                            sQuestion = sQuestion3;
                            sAnswer = sAnswer3;
                            bValid = true;
                            break;
                        default:
                            Console.WriteLine("Invalid entry. Try again.");
                            break;
                    }
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
