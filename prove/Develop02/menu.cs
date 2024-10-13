using System.ComponentModel.DataAnnotations;

class Menu
{
    // Attributes

    // Behaviors
    public string displayMenu()
    {
        string input;
        while(true)
        {       
            Console.Write("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n>> ");
            input = Console.ReadLine();
            try
            {
                if( 0 < int.Parse(input) && 5 >= int.Parse(input))
                {
                    break;
                }

                else
                    Console.WriteLine("Invalid input, please try again\n");
            }

            catch
            {
                Console.WriteLine("Invalid input, please try again\n");
            }
        }
        return input;
    }

    // CASES

    // Case 1 deals with making a new prompt, getting input, and saving it to a list in Journal myJournal
    public void case1(Journal myJournal)
    {
        Entry newEntry = new();
        string prompt = newEntry.generatePrompt();
        string entry = newEntry.displayPrompt(prompt);
        myJournal.addEntry(newEntry.saveResponse(prompt, entry));
    }

    // Case 3 loads an old journal from a text file
    public void case3(Journal myJournal)
    {
        Console.WriteLine("Enter a file to load:");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        myJournal._entries = [];
        foreach(string line in lines)
        {
            myJournal._entries.Add(line);
        }
    }

    // Case 4 saves all entries currently stored in Journal._entries to the chosen file
    public void saveFile(Journal myJournal)
    {
        Console.WriteLine("Enter a file name to save to:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach(string i in myJournal._entries)
            outputFile.WriteLine(i);
        }
    }
}