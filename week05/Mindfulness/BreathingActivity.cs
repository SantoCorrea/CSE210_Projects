public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing activity\n";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("Breath out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}