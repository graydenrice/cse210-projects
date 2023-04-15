using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);

        string letter = "";

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
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You failed");
        }
    }
}