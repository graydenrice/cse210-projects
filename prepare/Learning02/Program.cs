using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Marketing Director";
        job2._company = "Apple";
        job2._startYear = 2001;
        job2._endYear = 2019;

        Console.WriteLine(job2._company);

        job1.DisplayJob();
        job2.DisplayJob();

        Resume resume = new Resume();
        resume._personName = "Frankie";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.DisplayResume();
    }
}