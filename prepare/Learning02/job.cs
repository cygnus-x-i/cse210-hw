public class Job
{
    // Attributes
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // Behaviors
    public void displayInformation()
    {
        string job = $"{_jobTitle} ({_company}) | {_startYear} - {_endYear}";
        Console.WriteLine($"{job}");
    }

}