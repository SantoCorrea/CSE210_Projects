using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random () ;
        int magicNumber = randomGenerator.Next(1,101);
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Welcome to the 'WHAT IS THE MAGIC NUMBER GAME', good luck");

        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You guessed {attempts} times");
            }
        }


    }
}