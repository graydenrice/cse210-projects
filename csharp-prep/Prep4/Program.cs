using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int input = 0;
        while (input == 0)
        {
            Console.Write("Enter a List of Numbers, Type 0 when finnished: ");
            string user = Console.ReadLine();
            int number = int.Parse(user);

            if (number != 0) {
                numbers.Add(number);
            } else if (number < 0) {
                Console.WriteLine("Invald Number, Try Again");
            } else if (number == 0) {
                input += 1;
            }
        }
        int length = numbers.Count();

        int total = numbers.Sum();
        Console.WriteLine("Sum = {0}", total);

        int avg = total / length;
        Console.WriteLine("Average = {0}", avg);

        int max = numbers.Max();
        Console.WriteLine("The largest number is: {0}", max);
    }
}