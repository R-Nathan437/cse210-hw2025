using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Dell";
        job1._startYear = 2018;
        job1._endYear = 2022;
        Job job2 = new Job();
        job2._jobTitle = "Front-End Checkout Host";
        job2._company = "Walmart";
        job2._startYear = 2020;
        job2._endYear = 2021;
        
        Resume resume = new Resume();
        resume._name = "Adam Sandler";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}