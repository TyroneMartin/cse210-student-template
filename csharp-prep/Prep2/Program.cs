using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)

    // scale 
    // A >= 90
    // B >= 80
    // C >= 70
    // D >= 60
    // F < 60
    {

        Console.Clear();
        Console.WriteLine("##########################################");
        Console.WriteLine("Determines the letter grade");
        Console.WriteLine("##########################################\n");

        string response = "yes";
        while (response == "yes")
        {
            Console.Write("What is grade percentage? ");
            string userGradeInput = Console.ReadLine();
            int grade = int.Parse(userGradeInput);

            string letter = "";
            string letterSymbol = "";


            if (grade >= 90)
            {
                letter = "A";
            }

            else if (grade >= 80)
            {
                letter = "B";
            }

            else if (grade >= 70)
            {
                letter = "C";
            }

            else if (grade >= 60)
            {
                letter = "D";
            }

            else
            {
                letter = "F";
            }


            // Stretch Challenge     
            // don't worry about the exceptional cases of A+, F+, or F-.

            if (grade % 10 >= 7)
            {
                letterSymbol = "+";
            }
            else if (grade % 10 < 3)
            {
                letterSymbol = "-";
            }
            else
            {
                letterSymbol = "";
            }

            if (grade >= 70)
            {
                Console.WriteLine("You pass!");
            }
            else
            {
                Console.WriteLine("You failed!\n");
            }

            Console.WriteLine($"Your grade is: {letter}{letterSymbol} \n");

            
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine().ToLower();
        }

    }

}


