using System;
using System.Runtime.CompilerServices;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfull Program menu\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");

            Console.WriteLine("Please choose an activity:  ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if(choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if(choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if(choice == "4")
            {
                Console.WriteLine("Thanks for your time!");
                return;
            }

            else
            {
                Console.WriteLine("Please type a valid prompt.");
                Thread.Sleep(2000);
            }
        }
    }
}