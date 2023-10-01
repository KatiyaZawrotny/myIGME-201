using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UT1_Exercise_4
{
    internal class Program
    {
        //set up for timer
        static Timer timer;
        static bool timeUp;

        //declare chosen question/answer variables
        static string sQuestion = "";
        static string sAnswer = "";

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
                timeUp = false;
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
                //Ask question
                Console.WriteLine("You have 5 seconds to answer the following question:");
                Console.WriteLine(sQuestion);

                //re-declare bValid for reuse
                bValid = false;

                // prompt for the answer until they enter a valid response
                do
                {
                    timer = new Timer(5000);
                    timer.Elapsed += new ElapsedEventHandler(TimesUp);
                    timer.Start();

                    string sResponse = Console.ReadLine();


                    if (!timeUp)
                    {

                        if (sResponse.Equals(sAnswer))
                        {
                            bValid = true;
                            timer.Stop();
                            Console.WriteLine("Well done!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!  The answer is: " + sAnswer);
                            bValid = true;
                            timer.Stop();
                        }

                    }
                    else
                    {
                        bValid = true;
                        sResponse = "porcupine";
                        timer.Stop();
                    }
                    timer.Stop();
                } while (!bValid);
                //read response
                //determine if correct
                //print right answer if wrong
                //Ask if user would like to play again
                Console.Write("Play again? ");
                string sPlaying = Console.ReadLine();
                if (sPlaying.StartsWith("n"))
                {
                    bPlaying = false;

                }
                Console.WriteLine();
            }

        }
        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            // send a newline to the console to interrupt the user entry
            Console.WriteLine();

            // let the user know their time is up
            Console.WriteLine("Time's up!");


            Console.WriteLine("The answer is: " + sAnswer);

            // set the time out flag
            timeUp = true;

            // stop the timer, otherwise it will start over
            timer.Stop();
        }

    }
}
