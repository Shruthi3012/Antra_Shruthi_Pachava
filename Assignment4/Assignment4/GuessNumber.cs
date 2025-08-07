using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class GuessNumber
    {
        public static void Number()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess the number (1 - 3): ");
            int guessedNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.Write("Number out of Range. Enter number between 1 - 3 :");
                    guessedNumber = int.Parse(Console.ReadLine());
                }
                else
                    break;

            }
            if (guessedNumber < correctNumber)
                Console.WriteLine("Guessed low!");
            else if (guessedNumber > correctNumber)
                Console.WriteLine("Guessed high!");
            else
                Console.WriteLine("Guessed correct!");
        }
    }
}
