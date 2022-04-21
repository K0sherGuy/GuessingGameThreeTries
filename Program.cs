using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = 0;
            int guess = 0;
            int attempts = 0;
            random = rnd.Next(1, 11);
            while (true)
            {
                if (attempts == 3)
                {
                    Console.WriteLine($"You Lost! The correct number is: {random}");
                    break;
                }
                Console.WriteLine(random);
                Console.WriteLine("Please guess random number from 1 to 10:");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == random)
                {
                    Console.WriteLine($"You are right! The correct number is {random}");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"The number is invalid. It is your {attempts} attempt");
                }

            }
        }
    }
}
