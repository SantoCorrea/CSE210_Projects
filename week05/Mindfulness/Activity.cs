using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }

    public string Description
    {
        get {return _description;}
        set {_description = value;}
    }

    public int Duration
    {
        get {return _duration;}
        set {_duration = value;}
    }

    public Activity()
    {
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i =  seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};

        for (int i = 0; i < seconds * 4 ; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.Write("How long, in seconds, would you like for your session?  ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nGet ready to begin the {Name}");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(3);
        Console.WriteLine($"\nCongratulations you have completed the {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }
}

