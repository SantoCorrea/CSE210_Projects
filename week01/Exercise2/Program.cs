using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your percentage(number only, no symbols): ");
        string userScore = Console.ReadLine();

        int x = int.Parse(userScore);

        if (x >= 90)
        {
            Console.WriteLine("Your grade is A.");
        }

        else if (x >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }

        else if (x >= 70)
        {
            Console.WriteLine("Your grade is C.");
        }

        else if (x >= 60)
        {
            Console.WriteLine("Your grade is D.");
        }

        else
        {
            Console.WriteLine("Your grade is F.");
        }

        if (x >= 70)
        {
            Console.WriteLine("You have passed! congratulations.");
        }

        else
        {
            Console.WriteLine("You did not pass, sorry.");
        }



    }
}