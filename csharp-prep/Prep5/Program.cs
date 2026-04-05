using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        DisplayWelcome();


        string response = "yes";

        while (response == "yes")
        {


            try
            {
                // DisplayWelcome();
                string userName = PromptUserName();
                int userNumber = PromptUserNumber();

                int Square = SquareNumber(userNumber);

                int birthYear = 0000;
                PromtUserBirthYear(ref birthYear);

                DateTime currentYear = DateTime.Now;

                string getAge = ComputeBirthYear(currentYear, birthYear);

                DisplayResult(userName, Square, getAge);

                Console.Write("Do you want to try again? ");
                response = Console.ReadLine().ToLower();
            }

            catch (Exception e)
            {
                if (string.IsNullOrEmpty(e.Message))
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

    }


    // functions instruction

    static void DisplayWelcome()
    {
        // Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("===============================\n");

    }


    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }



    static void PromtUserBirthYear(ref int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static string ComputeBirthYear(DateTime currentDate, int birthYear)
    {

        int currentYear = currentDate.Year;

        {
            int age = currentYear - birthYear;
            return $"You are {age} years old this year ";

        }

    }


    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }

    static void DisplayResult(string name, int square, string getAge)
    {

        Console.Write($"~ {name} the square of your number is {square}. {getAge}\n");
        // Console.Write($"You are {birthYear - 2026} years old this year");

    }

}