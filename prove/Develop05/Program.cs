using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Menu
        Menu mainMenu = new Menu();
        bool run = true;

        // Main Loop
        while (run)
        {
            try
            {
                int choice = mainMenu.DisplayMenu();

                switch (choice)
                {
                    case 1:
                        // Create a new goal
                        mainMenu.CreateGoal();
                        break;

                    case 2:
                        // List all goals (this should display the list once and return to the menu)
                        mainMenu.ListGoals();
                        break;

                    case 3:
                        // Save goals to a file
                        mainMenu.SaveGoals();
                        break;

                    case 4:
                        // Load goals from a file
                        mainMenu.LoadGoals();
                        break;

                    case 5:
                        // Record an event
                        mainMenu.RecordEvent();
                        break;

                    case 6:
                        // Exit the program
                        Console.WriteLine("Goodbye!");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
