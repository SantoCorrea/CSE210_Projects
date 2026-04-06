public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        Name = "Reflecting Activity";
        Description = "This activity will make you reflect in your life with the help of a few questions\n";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you made someone smile.",
            "Think of a time when you overcame a fear.",
            "Think of a time when you kept going despite wanting to quit.",
            "Think of a time when you forgave someone who hurt you.",
            "Think of a time when you made a difficult but right decision.",
            "Think of a time when you supported a friend in need.",
            "Think of a time when you learned from a mistake.",
            "Think of a time when you achieved something you thought was impossible.",
            "Think of a time when you showed kindness to a stranger.",
            "Think of a time when you stood up for what you believed in.",
            "Think of a time when you helped your family through a hard moment.",
            "Think of a time when you showed patience in a frustrating situation.",
            "Think of a time when you inspired someone else.",
            "Think of a time when you stepped outside your comfort zone.",
            "Think of a time when you turned a failure into a lesson."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            ShowCountDown(5);
            Console.WriteLine(GetRandomQuestion());
            ShowCountDown(5);
            Console.WriteLine(GetRandomQuestion());
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndingMessage();
    }
}