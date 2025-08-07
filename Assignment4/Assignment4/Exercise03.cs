using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class Exercise03
    {
    
        public static void FizzBuzz()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        public static void TestByteCode()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if(i == byte.MaxValue )
                {
                    Console.WriteLine("Byte limit exceeds for next iteration causing overflow ");
                }
                Console.WriteLine(i);
            }
        }

        public static void GuessNumber()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess the number (1 - 3): ");
            int guessedNumber = int.Parse(Console.ReadLine());
            while(true)
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
