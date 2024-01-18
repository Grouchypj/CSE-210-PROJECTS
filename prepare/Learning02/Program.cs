using System;

public class Job
{
    // Member variables
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
public class Resume
{
    // Member variables
    private string _personName;
    private List<Job> _jobs;

    // Constructor
    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    // AddJob method
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
class Program
{
    static void Main()
    {
        // Create jobs
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Display jobs
        job1.Display();
        job2.Display();

        // Create resume
        Resume myResume = new Resume("Allison Rose");

        // Add jobs to resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume
        myResume.Display();
    }
}
