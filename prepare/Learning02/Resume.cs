using System;

public class Resume
{

    public string _name;
    public List<Job> _jobs = new List<Job>();

    // not using constructor since I am using pubic memember variables/attributes

    public void DisplayResumeDetails()
    {
        Console.WriteLine("_____________________");

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("_____________________");
        Console.WriteLine($"Jobs: ");
        Console.WriteLine("_____________________");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
        Console.WriteLine("_____________________");
        Console.WriteLine();


    }


}