using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public List<Goal> goals
    {
        get {return _goals;}
        set {_goals = value;}
    }

    public int score
    {
        get {return _score;}
        set {_score = value;}
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0; 
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
       for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];

        selectedGoal.RecordEvent();

        _score += selectedGoal.Points;

        if (selectedGoal is ChecklistGoal checklist && checklist.IsComplete())
        {
            _score += checklist.Bonus;
        }
    }

    public void SaveGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        _goals.Clear();
    }

    public void start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Create new goal.");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event.");
            Console.WriteLine("4. Show score.");
            Console.WriteLine("5. Save goals.");
            Console.WriteLine("6. Load goals.");
            Console.WriteLine("7. Quit");

            Console.WriteLine("Please select your option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                RecordEvent();
            }

            else if (choice == "4")
            {
                DisplayPlayerInfo();
            }

            else if (choice == "5")
            {
                SaveGoals();
            }

            else if (choice == "6")
            {
                LoadGoals();
            }

            else if (choice == "7")
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}