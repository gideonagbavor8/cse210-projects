using System;
using System.Collections.Generic;

class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
}

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (var job in _jobs)
        {
            Console.WriteLine($"Company: {job._company}, Job Title: {job._jobTitle}, Start Year: {job._startYear}, End Year: {job._endYear}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Creat job instances
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2026;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2029;
        job2._endYear = 2031;

        // Create resume instance
        Resume resume = new Resume();
        resume._name = "Gideon Komla Agbavor";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display resume details
        resume.Display();
    }
}