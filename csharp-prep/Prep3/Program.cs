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

        Console.Write("What is the magic number? ");

        string userInputMagicNum;
        userInputMagicNum = Console.ReadLine();
        int randomNumber = int.Parse(userInputMagicNum);

        do
        {
            // user entry/guess number
            Console.Write("What is your guess? ");


            // manual test 
            string userResponse = Console.ReadLine();
            int userGuess = int.Parse(userResponse);
            string systemResponse = "";

            if (randomNumber == userGuess)
            {
                // systemResponse = "You guessed it! \n";
                Console.Write("You guessed it! \n");

                Console.Write("Do you want to continue? ");
                continueGame = Console.ReadLine().ToLower();
                Console.Write("What is the magic number? ");

            }

            else if (randomNumber > userGuess)
            {
                systemResponse = "Higher";
            }
            else
            {
                systemResponse = "Lower";
            }

            // print systemResponse to the console 
            Console.WriteLine($"{systemResponse}");

        } while (continueGame == "yes");

    }

}