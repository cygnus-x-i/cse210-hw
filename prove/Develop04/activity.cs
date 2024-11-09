using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Activity
{
    // Attributes
    public int _actTime;

    //  Behaviors
    
    public void StartMessage(string description)
    {
        Console.Write(description);
    }

    public void EndMessage(string endMessage)
    {
        Console.WriteLine(endMessage);
    }

    public void Loading(int time)
{
    // this was funny so i left it in.  it is not ideal
    string loadingString = "";
    for(int j = 0; j < time; j++)
    {
        for (int i = 1; i <= 8; i++)
        {

            if (i == 1)
            {
                loadingString = "=----";
            }
            else if (i == 2)
            {
                loadingString = "-=---";
            }
            else if (i == 3)
            {
                loadingString = "--=--";
            }
            else if (i == 4)
            {
                loadingString = "---=-";
            }
            else if (i == 5)
            {
                loadingString = "----=";
            }
            else if (i == 6)
            {
                loadingString = "---=-";
            }
            else if (i == 7)
            {
                loadingString = "--=--";
            }
            else if (i == 8)
            {
                loadingString = "-=---";
            }
            
            Console.Write(loadingString);
            Thread.Sleep(100);
            Console.Write("\b\b\b\b\b");
            // Console.Clear();
            // ClearLastCharacters(5);
        }
    }
}

    public void StartActivity(string endMessage, Func<int> function)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_actTime);
        // Console.WriteLine("entering loop"); //for debug

        // Main Loop
        Console.Clear();
        Console.WriteLine("Get ready... ");
        Loading(4);
        Console.Clear();

        while(true)
        {

            int x = function();
            
            DateTime datetime = DateTime.Now;

            if (futureTime < datetime)
            {
                break;
            }

            Thread.Sleep(100);
        }

        EndMessage(endMessage);
        Console.Write("Press Enter to continue.");
        Console.ReadLine();
        // Console.WriteLine("Left loop"); //for debug
    }

    public void SetTime()
    {
        _actTime = int.Parse(Console.ReadLine());
    }
}