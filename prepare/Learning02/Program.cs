using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("###############################");
        Console.WriteLine("       Employment History    ");
        Console.WriteLine("###############################\n");


        Job job1 = new Job();  // instance of the Job class

        job1._company = "Xerox";
        job1._jobTitle = "Systems Admin";
        job1._startYear = 2010;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Ibex";
        job2._jobTitle = "Lead QA";
        job2._startYear = 2010;
        job2._endYear = 2008;

        Job job3 = new Job();
        job3._company = "Itel";
        job3._jobTitle = "Customer Service Representative";
        job3._startYear = 2008;
        job3._endYear = 2007;


        Resume resume = new Resume();
        resume._name = "Alison Smith";


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.DisplayResumeDetails();

    }
}