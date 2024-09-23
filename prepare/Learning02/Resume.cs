using System;
using System.Reflection.Metadata;

public class Resume
        {
            public string _personName;
            public List<Job> _jobs = new List<Job>();


            
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
            
        }