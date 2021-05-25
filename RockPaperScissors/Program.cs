using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors - Shoot!");
            RockPaperScissors();
            


        

        }
        static void RockPaperScissors()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Choose Rock(R), Paper(P), or Scissors(S): ");
                Console.Beep();


                int computerGuess = new Random().Next(0, 3);
                bool stillPlaying = true;
                while (stillPlaying)
                {
                    string input = Console.ReadLine();
                    switch (input.ToUpper())
                    {
                        //0 = Rock 1 = Paper 2 = Scissors
                        case "ROCK":
                        case "R":
                            if (computerGuess == 2)
                            {
                                Console.WriteLine("You Win!");
                            }
                            else if (computerGuess == 1)
                            {
                                Console.WriteLine("You Lose!");
                            }
                            else if (computerGuess == 0)
                            {
                                Console.WriteLine("Tie Game.");
                            }
                            stillPlaying = false;
                            break;
                        case "PAPER":
                        case "P":
                            if (computerGuess == 2)
                            {
                                Console.WriteLine("You Lose!");
                            }
                            else if (computerGuess == 1)
                            {
                                Console.WriteLine("Tie Game.");
                            }
                            else if (computerGuess == 0)
                            {
                                Console.WriteLine("You Win!");
                            }
                            stillPlaying = false;
                            break;
                        case "SCISSORS":
                        case "S":
                            if (computerGuess == 2)
                            {
                                Console.WriteLine("Tie Game.");
                            }
                            else if (computerGuess == 1)
                            {
                                Console.WriteLine("You Win!");
                            }
                            else if (computerGuess == 0)
                            {
                                Console.WriteLine("You Lose!");
                            }
                            stillPlaying = false;
                            break;
                        default:
                            Console.WriteLine("Error, that was not an option!");
                            break;

                    }
                }
                
                bool HasRespondedCorrectly = false;
                while (!HasRespondedCorrectly)
                {
                    Console.WriteLine("Play again? Y/N");
                    string Input = Console.ReadLine();
                    switch (Input.ToUpper())
                    {
                        case "Y":
                            HasRespondedCorrectly = true;
                            Console.Clear();
                            continue; //do nothing.
                        case "N":
                            HasRespondedCorrectly = true;
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please enter either Y for yes or N for no.");
                            break;
                    }
                }


            }
        }
    }
}
