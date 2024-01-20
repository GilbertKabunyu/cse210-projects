using System;



class Program
{
    public string Company {get; set;}
    public string JobTitle {get; set;}
    public int StartYear {get; set;}
    public int EndYear {get; set;}

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        Company = company;
        JobTitle = jobTitle;
        StartYear = startYear;
        EndYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

public class Resume
{
    public string Name {get; set;}
    public List<Job> Jobs {get; set;}

    public Resume(string name)
    {
        Name = name;
        Jobs = new List<Job>();
    }

    public void AddJobs(Job job)
    {
        Jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine(Name);
        foreach(Job job in Jobs)
        {
            job.Display();
        }
    }
    static void Main(string[] args)
   {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022,2023);

        Resume myResume = new Resume("Allison Rose");
        myResume.AddJobs(job1);
        myResume.AddJobs(job2);

        myResume.Display();
   } 

} 