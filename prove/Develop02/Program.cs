using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new();
        Menu mainMenu = new();
        while(true)
        {
            string input = mainMenu.displayMenu();
            if (input != "5")
            {
                switch(input)
                {
                    // Case 1: Generate and display prompt, get input and save to Journal._entries
                    case "1":
                        mainMenu.case1(myJournal);
                        break;
                    // Case 2: Displays all entries in myJournal
                    case "2":
                        myJournal.displayAll();
                        break;
                    // Case 3: Load a previous journal from a text file
                    case "3":
                        mainMenu.case3(myJournal);
                        break;
                    // Case 4: Save written entries to a new file
                    case "4":
                        mainMenu.saveFile(myJournal);
                        break;
                }
            }
            // Breaks main loop if the user enters 5 on the main menu
            else
                break;
        }
    }
}