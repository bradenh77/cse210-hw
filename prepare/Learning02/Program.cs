using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2025;
        job2._endYear = 2030;

        Resume resume1 = new Resume();
        resume1._name = "Braden Hall";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();
    }
}