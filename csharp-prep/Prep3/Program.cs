using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

            int loop = 0;
            while (loop == 0)
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1,100);

                Console.Write("What is the magic number? ");
                string userinput = Console.ReadLine();
                int guess = int.Parse(userinput);

                if ( guess > number){
                    Console.WriteLine("Lower");
                } if (guess < number) {
                    Console.WriteLine("Higher");
                } if (guess == number){
                    Console.WriteLine("You guessed right!");
                    loop += 1;
                }
            }
    }
}