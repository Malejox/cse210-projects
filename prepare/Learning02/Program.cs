using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create Job instances
        Job job1 = new Job();
        job1._jobTitle = "Cybersecurity Analyst";
        job1._company = "Google";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "CISO";
        job2._company = "Tesla";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // 2. Create Resume instance
        Resume myResume = new Resume();
        myResume._name = "Manuel Baez Severino";

        // 3. Add jobs to the resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // 4. Display the entire resume with one call
        myResume.Display();
    }
}