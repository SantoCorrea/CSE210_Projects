public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted
    {
        get {return _amountCompleted;}
        set {_amountCompleted = value;}
    }

    public int Target
    {
        get {return _target;}
        set {_target = value;}
    } 

    public int Bonus
    {
        get {return _bonus;}
        set {_bonus = value;}
    }

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        double completedAmount = _amountCompleted;
        double progress = (completedAmount / _target) * 100;

        if (progress == 100)
        {
            Console.WriteLine("Congratulations for your effort, you did it!");
        }

        else if (progress == 15)
        {
            Console.WriteLine("Do not stop, keep going");
        }

        else if (progress == 25)
        {
            Console.WriteLine("You are doing a great job, do not stop!");
        }

        else if (progress == 35)
        {
            Console.WriteLine("You are improving yourself so much, keep going!");
        }

        else if (progress == 50)
        {
            Console.WriteLine("You are halfway to your goal, you are doing great, congrats!");
        }

        else if (progress == 65)
        {
            Console.WriteLine("Keep working on this goal, you are great, you can do it");
        }

        else if (progress == 80)
        {
            Console.WriteLine("You are almost there, do not stop, keep going, you will succeed");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        if(_amountCompleted == _target)
        {
            return $"[X] {GetDetailString()} ----- completed {_amountCompleted}/{_target}";  
        }

        else
        {
            return $"[ ] {GetDetailString()} ----- completed {_amountCompleted}/{_target}";
        }
    }
}

