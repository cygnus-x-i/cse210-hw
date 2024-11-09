using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // make these in the main loop then destroy them after each trip through the loop?
        //maybe
        Reflection reflection = new();

        Breathing breathing = new();

        Listing listing = new();

        bool running = true;
        // Main Loop
        while(running)
        {
            switch(menu())
            {
                case(1): //breathing activity
                    ChangeTextColor(ConsoleColor.Green);
                    Console.WriteLine(breathing.getDescription());
                    breathing.SetTime();
                    breathing.StartActivity(breathing.GenerateEndMessage(), breathing.BreathingActivity);
                    ResetTextColor();
                    break;

                case(2): //reflection
                    ChangeTextColor(ConsoleColor.Blue);
                    Console.WriteLine(reflection.getDescription());
                    reflection.SetTime();
                    reflection.StartActivity(reflection.GenerateEndMessage(), reflection.ReflectionActivity);
                    ResetTextColor();
                    break;

                case(3): //listing
                    ChangeTextColor(ConsoleColor.Red);
                    Console.WriteLine(listing.getDescription());
                    listing.SetTime();
                    listing.StartActivity(listing.GenerateEndMessage(), listing.ListingAct);
                    ResetTextColor();
                    break;

                // Breaks running loop, ends program
                case(4): 
                    running = false;
                    break;
            }
        }
    }



    // displays menu and gets input
    // didn't put in its own class because its too small
    static int menu()
    {   
        
        while(true)
        {
            try
            {
                Console.Clear();
                Console.Write("Menu Options:\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listing Activity\n   4. Quit\nSelect an option: ");
                int returnVal = int.Parse(Console.ReadLine());
                if(returnVal <= 4 && returnVal >= 1)
                {
                    Console.Clear();
                    return returnVal;
                }
                else
                {
                    // there is probably a more efficient way to do this
                    throw new Exception();
                }
            }

            catch
            {
                Console.Clear();
                Console.WriteLine("Input not recognized, please try again.");
                Reflection reflection = new();
                reflection.Loading(3);
            }
        }
    }

    static void ChangeTextColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void ResetTextColor()
    {
        Console.ResetColor();
    }

}

