using System;
using System.Data;
using System.Threading;

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

        int guessCounter = 0;

        Random numberGenerator = new Random();
        int randomNumber = numberGenerator.Next(1, 101);

        // test random 
        Console.WriteLine($"Random number is {randomNumber}");


        do
        {
            // user entry/guess number
            Console.Write("What is your guess? ");
            guessCounter++;     // Stretch Challenge 1
            string userResponse = Console.ReadLine();
            int userGuess = int.Parse(userResponse);

            // exceptional  entry cases exsist will leave for now
            // for none integer values


            if (randomNumber == userGuess)
            {
                Console.Write("You guessed it! \n");
                Console.Write($"Guess total: {guessCounter}\n");

                // Stretch Challenge 2
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
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Thanks for playing, good by!!!");
                    Console.WriteLine("=================================\n");
                    Thread.Sleep(300); 
                    // notes
                    // 10000 = Simulating other work (10 seconds)
                    // 1000 = 1 second
                    // 100 = millisecond                    
                    break;
                }

                // generating new numbers if user contines 
                // from the numberGenerator instance from the Ramdom class

                randomNumber = numberGenerator.Next(1, 101);  // notes: Next(min, max)  ... Generates numbers from min (inclusive) to max (exclusive)

                // test random
                Console.WriteLine($"Random number is {randomNumber}");


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