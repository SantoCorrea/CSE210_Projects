public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    
    public ListingActivity()
    {
        _count = 0;
        Name = "Listing Activity\n";
        Description = "This activity will help you to think about your life and list all the important things.\n";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What is your personal reason not to give up?",
            "What are some really good skills that you have?",
            "What truth about myself am I currently denying?",
            "Am I spending my time the way I truly want to spend it?",
            "What current habit is stopping me from making progress?",
            "What am I willing to struggle for because it is worth it?",
            "What can I do to improve by 1% today?",
            "What action can I take in the next 5 minutes that I'll be proud of?",
            "What is the most important lesson I ve learned recently?",
            "What advice would my future self give me right now?",
            "What current habit is stopping me from making progress?",
            "What is the bravest thing I could do today?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            ShowCountDown(5);
            Console.WriteLine(GetRandomPrompt());
            ShowCountDown(5);
            GetListFromTheUser();
            Console.WriteLine($"You listed {_count} items!");
            DisplayEndingMessage();
        }
    }

    public string GetRandomPrompt()
    {
       Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index];
    }

    public List<string> GetListFromTheUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write(">");
            string item = Console.ReadLine();
            items.Add(item);
            _count++;
        }
        return items;

    }
}