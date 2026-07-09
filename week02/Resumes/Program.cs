using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "Liberty Youth Academy";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Child Caretaker";
        job2._company = "Close Friend";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Job job3 = new Job();
        job3._jobTitle = "Administrator";
        job3._company = "Salmagundi Scholar";
        job3._startYear = 2026;
        job3._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Nathan R. Hibberd";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}