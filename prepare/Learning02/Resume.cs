using System;
using System.Collections.Generic;

public class Resume
{
    private string _name;
    private List<Job> _jobs;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Job> Jobs
    {
        get { return _jobs; }
        set { _jobs = value; }
    }

    // Constructor
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display resume details
    public void Display()
    {
        Console.WriteLine($"Resume of {_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
