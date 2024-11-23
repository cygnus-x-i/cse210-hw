using System;
using System.IO;
using System.Collections.Generic;

class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        int goalType = DisplaySubMenu();
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();
        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the point value: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            Simple simpleGoal = new Simple();
            simpleGoal.Initialize(title, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalType == 2)
        {
            Eternal eternalGoal = new Eternal();
            eternalGoal.Initialize(title, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == 3)
        {
            Console.Write("Enter the target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            Checklist checklistGoal = new Checklist();
            checklistGoal.Initialize(title, description, points, targetCount, bonusPoints);
            _goals.Add(checklistGoal);
        }
    }

    public void ListGoals()
{
    // Ensure the goals are displayed only once
    Console.WriteLine("\nYour Goals:");
    if (_goals.Count == 0)
    {
        Console.WriteLine("You have no goals yet.");
    }
    else
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.GetTitle()} ({goal.GetDescription()})");
        }
    }
    Console.WriteLine($"Total Score: {_score}");
}


    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Select a goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].RecordEvent();
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.csv"))
        {
            writer.WriteLine(_score); // Score is first line in csv
            foreach (var goal in _goals)
            {
                if (goal is Simple)
                {
                    writer.WriteLine($"Simple,{goal.GetTitle()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsDone()}");
                }
                else if (goal is Eternal)
                {
                    writer.WriteLine($"Eternal,{goal.GetTitle()},{goal.GetDescription()},{goal.GetPoints()}");
                }
                else if (goal is Checklist checklistGoal)
                {
                    writer.WriteLine($"Checklist,{goal.GetTitle()},{goal.GetDescription()},{goal.GetPoints()},{checklistGoal.GetTimesCompleted()},{checklistGoal.GetTargetCount()},{goal.IsDone()}");
                }
            }
        }
        Console.WriteLine("Goals successfully saved to goals.csv!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.csv"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader("goals.csv"))
        {
            _score = int.Parse(reader.ReadLine()); // First line is the score

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalType = parts[0];
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "Simple")
                {
                    Simple simpleGoal = new Simple();
                    simpleGoal.Initialize(title, description, points);
                    if (bool.Parse(parts[4]))
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                else if (goalType == "Eternal")
                {
                    Eternal eternalGoal = new Eternal();
                    eternalGoal.Initialize(title, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "Checklist")
                {
                    int timesCompleted = int.Parse(parts[4]);
                    int targetCount = int.Parse(parts[5]);
                    bool isDone = bool.Parse(parts[6]);

                    Checklist checklistGoal = new Checklist();
                    checklistGoal.Initialize(title, description, points, targetCount, 0);
                    for (int i = 0; i < timesCompleted; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                }
            }
        }
        Console.WriteLine("Goals successfully loaded from goals.csv!");
    }

    public int DisplayMenu()
    {
        Console.WriteLine("\nPlease select an option from the following:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplaySubMenu()
    {
        Console.WriteLine("\nTypes of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a type of goal to create: ");
        return int.Parse(Console.ReadLine());
    }
}
