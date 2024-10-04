public class Resume
{
    // Attributes
    public string _personFirstName;
    public string _personLastName;
    public List<Job> _jobs = new();

    // Behaviors
    public void displayResume()
    {
        Console.WriteLine($"{_personFirstName} {_personLastName}");
        foreach(Job i in _jobs)
        {
            i.displayInformation();
        }
    }

}