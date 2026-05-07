using System;
using System.Collections.Generic;

public class Resume
{
    public string _name = "";

    // Initialize the list to avoid "Null Reference" errors
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice how we leverage the abstraction already built in the Job class
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}