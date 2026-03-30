using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("===========================================");
        Console.WriteLine("Enter a list of numbers, \ntype 0 when finished.");
        Console.WriteLine("===========================================\n");


        // using built-in methods and proverties instead of functions

        List<int> listOfNums = new List<int>();


        int userEntry = -1;


        while (userEntry != 0)
        {

            Console.Write("Enter number: ");
            userEntry = int.Parse(Console.ReadLine());
            listOfNums.Add(userEntry);

        }

        if (userEntry == 0)
        {
            listOfNums.Remove(0);
        }


        // for (int i = 0; i < listOfNums.Count; i++)


        float sum = listOfNums.Sum();
        double avg = listOfNums.Average();
        float max = listOfNums.Max();





        Console.WriteLine($"\n~~~~~~[Calculated Values]~~~~~~");

        Console.WriteLine($"The sum is              : {sum}");
        Console.WriteLine($"The average is          : {avg} ");
        Console.WriteLine($"The largest is          : {max}");
        // Console.WriteLine($"The smallest positive is: {min}");


       
       // Stretch Challenge

        var positiveNums = listOfNums.Where(number => number > 0).ToList();

        if (positiveNums.Count > 0)
        {
            int min = positiveNums.Min();
            Console.WriteLine($"The smallest positive is: {min}");
        }
        else
        {
            Console.WriteLine("No positive value for min");
        }


        Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


        Console.WriteLine($"\n~~~~~~[Sorted values]~~~~~~");
        listOfNums.Sort();


        foreach (int number in listOfNums)
        {
            Console.WriteLine($"{number}");

        }
        Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");

    }


}