using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        MathAssignment math = new MathAssignment("Grayden", "Math", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Grayden", "History", "World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}