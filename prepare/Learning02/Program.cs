using System;

class Program
{
    static void Main(string[] args)
    {
        Job microsoft = new();
        microsoft._company = "Microsoft";
        microsoft._endYear = "2004";
        microsoft._jobTitle = "Engineer";
        microsoft._startYear = "0004";

        Resume resume = new();
        resume._personFirstName = "Jens";
        resume._personLastName = "Helquist";
        resume._jobs.Add(microsoft);
        resume.displayResume();
    }
}