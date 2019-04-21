

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
   class Guess_my_number__computer_plays
    {
        int RadomNum;
        int MinMin;
        int MaxMax;
        bool guessed;


        public void GameOptions()
        {

            Console.WriteLine($"\nThe computer just asked is {RadomNum} your number?");
            Console.WriteLine("Select from the options below.\n" + "Q: Awe to Low, you better try again" + " W: Awe to High, you better try again. " + " E: Yes that is my the number I Picked");

            var name = Console.ReadKey(true).Key;

            switch (name)

            {
                case ConsoleKey.Q:
                    MinMin = ((MinMin + MaxMax) / 2) + 1;
                    break;

                case ConsoleKey.W:
                    MaxMax = ((MinMin + MaxMax) / 2) - 1;
                    break;

                case ConsoleKey.E:
                guessed = false;
                    break;

                default:

                    Console.WriteLine("Invalid Input Please Select fro the options below\n");
                    GameOptions();
                    break;
            }

        }


        public void FinalTask()
        {
            int maxValue = 100;
            int minValue = 1;

            Console.WriteLine("Think of a number between 1 and 100 that you want the computer to guess.");
            Console.WriteLine();

         int[] numbers = Enumerable.Range(minValue, maxValue).ToArray();

            guessed = true;

            int count = 0;

            MinMin = 0;

            MaxMax = maxValue - 1;

            while (guessed)
            {
                count++;
                RadomNum = numbers[(MinMin + MaxMax) / 2];
                GameOptions();
            }

            Console.WriteLine();
            Console.WriteLine($"You finally guessed the right number. Yay! The number was {RadomNum}!");
            Console.WriteLine($"It took you {count} tries..");
            Console.WriteLine("Thanks for Playing (^.^)");


        }

      
    }

}
