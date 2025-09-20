using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2024;

        string Job2Title = "Cloud Engineer";

        Job job2 = new Job();
        job2._jobTitle = Job2Title;
        job2._company = "Google";
        job2._startYear = 2017;
        job2._endYear = 2020;


        Resume resume = new Resume();

        resume._name = "John";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

        //            resume._jobs[0]._jobTitle;
    }
}