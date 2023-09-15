using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Parsing_And_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate a random correct number
            Random rand = new Random();
            while (true)
            {
                int randomNumber = rand.Next(1, 101);
                Console.WriteLine($"\nTEST: CORRRECT NUMBER IS {randomNumber}");
                //The user gets 8 guesses
                int guessesLeft = 8;
                bool winCondition = false;
                int guess;
                //Welcoming statement and instructions
                Console.WriteLine("Welcome to The Number Guesser! Your goal is to guess the mystery number from 1 to 100! You have 8 guesses!");
                //Loops while game is not won and player isn't out of guesses.
                while (!winCondition && guessesLeft>0) 
                {
                    try 
                    {
                        //loop asks for a number, catches if not int or not in bounds
                        Console.Write($"ENTER GUESS #{9 - guessesLeft} --> ");
                        int.TryParse(Console.ReadLine(), out guess);
                        //checks for in bounds
                        if (guess > 100 || guess < 1)
                        {
                            Console.WriteLine("Please enter a number from 1 to 100! (No guess was used)");
                            continue;
                        }
                        //checks if correct. decrements for fencepost
                        if (guess == randomNumber)
                        {
                            Console.WriteLine("You got it!!");
                            winCondition = true;
                            guessesLeft--;
                            break;
                        }
                        //checks if less than answer
                        else if (guess < randomNumber)
                        {
                            Console.WriteLine("Your guess was smaller than the secret number.");
                            guessesLeft--;
                        }
                        //checks if greater than answer
                        else if (guess > randomNumber)
                        {
                            Console.WriteLine("Your guess was larger than the secret number.");
                            guessesLeft--;
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("Please enter a valid integer.");
                    }  

                    
                }
                //text if run out of guesses
                if (guessesLeft <= 0) 
                {
                    Console.WriteLine($"You ran out of guesses! The correct number was {randomNumber}. Would you like to play again? (YES/NO): ");
                }
                //text if won game
                else
                {
                    Console.WriteLine($"You won in {8-guessesLeft} guesses! The correct number was {randomNumber}! Would you like to play again? (YES/NO): ");
                }

                //ask to play again or end game
                string playing = Console.ReadLine().ToLower().Trim();
                if (playing == "yes" || playing == "y")
                {
                    //add a blank space and restart the game.
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    //end the loop and program
                    Console.WriteLine("Goodbye! See you next time!!");
                    break;
                }
                
            }
            


        }
    }
}
