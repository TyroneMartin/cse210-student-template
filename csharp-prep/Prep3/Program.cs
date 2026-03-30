using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("Guess a number!");
        Console.WriteLine("==========================\n");

        string continueGame = "yes";

        // =================== Manual test ====================
        /*
               Console.Write("What is the magic number? ");
               string userInputMagicNum;
               userInputMagicNum = Console.ReadLine();
               int randomNumber = int.Parse(userInputMagicNum);
       */
        // =======================================================

        Random numberGenerator = new Random();
        int randomNumber = numberGenerator.Next(1, 100);

        // test random 
        Console.WriteLine($"Random number is {randomNumber}");


        do
        {
            // user entry/guess number
            Console.Write("What is your guess? ");
            string userResponse = Console.ReadLine();
            int userGuess = int.Parse(userResponse);

            // exceptional  entry cases exsist will leave for now
            // for none integer values


            if (randomNumber == userGuess)
            {
                Console.Write("You guessed it! \n");

                // Stretch Challenge
                Console.Write("Do you want to continue [Yes/No]? ");
                continueGame = Console.ReadLine().ToLower();

                // Validate input
                while (continueGame != "yes" && continueGame != "no")
                {
                    Console.Write("Please enter Yes or No: ");
                    continueGame = Console.ReadLine().ToLower();
                }

                // if no exit loop 
                if (continueGame == "no")
                {
                    break;
                }

                // generating new numbers if user contines 
                // from the numberGenerator instance from the Ramdom class
                randomNumber = numberGenerator.Next(1, 101);

            }

            else if (randomNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

        } while (continueGame == "yes");

    }

}