using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numbermagic = randomGenerator.Next(1, 101);
        
        int guess = -1;
        while (guess != numbermagic)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > numbermagic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < numbermagic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess == numbermagic)
                {
                    Console.WriteLine("You guessed it!");
                }
            }
    }
}