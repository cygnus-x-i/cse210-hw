using System.ComponentModel;
using System.Runtime.CompilerServices;

class Activity
{
    // Attributes
    int _time;

    //  Behaviors
    
    public void StartMessage()
    {

    }

    public void EndMessage()
    {

    }

    public void Loading()
{
    string loadingString = "";
    for(int j = 0; j<20; j++)
    {
        for (int i = 0; i <= 9; i++)
        {
            if (i == 0)
            {
                loadingString = "-----";
            }
            else if (i == 1)
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
            else if (i == 9)
            {
                loadingString = "=----";
            }
            
            Console.WriteLine(loadingString);
            Thread.Sleep(100);
            ClearLastCharacters(5);
        }
    }
}


    public void StartActivity()
    {

    }

    public int GetTime()
    {
        return _time;
    }

    public void ClearLastCharacters(int count)
    {
        // Get the current cursor position
        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

        // Move the cursor back by 'count' characters
        Console.SetCursorPosition(cursorLeft - count, cursorTop);

        // Overwrite with spaces
        Console.Write(new string(' ', count));

        // Move the cursor back again to the original position
        Console.SetCursorPosition(cursorLeft - count, cursorTop);
    }

}