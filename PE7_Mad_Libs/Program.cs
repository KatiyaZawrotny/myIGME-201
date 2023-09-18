using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7_Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parse the file
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            string finalStory = "";

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            //input = new StreamReader("c:/templates/MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt the user for which Mad Lib they want to play (nChoice)

            // split the Mad Lib into separate words


            //Count how many lines (stories) there are in the file

            //Prompt user if they would like to play MadLibs
            Console.WriteLine("Welcome to MadLibs! Would you like to play? (YES/NO):");
            while (true)
            {
                string playing = Console.ReadLine().ToLower().Trim();
                if (playing == "no" || playing == "n")
                {
                    Console.WriteLine("Too bad! Goodbye! So long! Farewell!");
                    break;
                }
                else if (playing == "yes" || playing == "y")
                {
                    Console.WriteLine("Let's play!!");


                    //Prompt User for name
                    Console.Write("Please enter your name --> ");
                    string userName = Console.ReadLine();

                    //Prompt User for a story number 1 through numLibs



                    while (true)
                    {
                        Console.Write($"Hey there, {userName}! Pick a story number, 1 through {numLibs} --> ");
                        try
                        {
                            int.TryParse(Console.ReadLine(), out nChoice);
                            if (nChoice < 1 || nChoice > numLibs)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Whoah there! That's not a valid number!");
                        }
                    }

                    //Use String.Split() to parse each word out of the chosen story's template.
                    //If the current word is '\n', concatenate the escape sequence '\n' to resultString
                    //If the current word is '{' then it is a prompt for the user.
                    //Use String.Replace() to replace the "_" in the prompts with spaces. Do not include the {} in the prompt.
                    string[] words = madLibs[nChoice].Split(' ');

                    foreach (string word in words)
                    {
                        // if word is a placeholder
                        if (word[0] == '{')
                        {
                            string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                            // prompt the user for the replacement
                            Console.Write("Input a {0}: ", replaceWord);
                            // and append the user response to the result string
                            finalStory += Console.ReadLine() + " ";
                        }
                        // else append word to the result string
                        else
                        {
                            finalStory += word + " ";
                        }
                    }
                    //Load all lines into a string array

                    //Prompt User for the inputs

                    //Print the final story with user's answers
                    Console.Out.WriteLine(finalStory);
                    break;
                }
                else { Console.WriteLine("Invalid answer."); }

            }


        }
    }
}
