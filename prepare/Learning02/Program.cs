using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Software Engineer"; // Corrected syntax
        job1.Company = "Microsoft"; // Corrected syntax
        job1.StartYear = 2019;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.JobTitle = "Manager"; // Corrected syntax
        job2.Company = "Apple"; // Corrected syntax
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose"; // Corrected syntax

        myResume.Jobs.Add(job1); // Corrected syntax
        myResume.Jobs.Add(job2); // Corrected syntax

        myResume.Display();
    }
}

class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }
}

class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>(); // Added initialization
    public void Display()
    {
        // Display resume information
    }
}