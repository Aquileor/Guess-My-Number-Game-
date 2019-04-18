

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Guess_my_number__computer_plays
    {
        static int NumRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static int CompGuess(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void LastTask()
        {

            while (true)
            {
                int randomNum = NumRange(1, 10);

                int guess = CompGuess(1, 10);

                int count = 1;

                while (true)
                {
                    Console.WriteLine("The Computer is going to guess a number that has to be between 1 and 10.\n(If you want to quit at any time press 0):");
                    Console.Write("\nMy Number is: ");


                    int InputVar = guess;
                    if (InputVar == 0)

                        return;

                    else if (InputVar > randomNum)
                    {
                        Console.WriteLine("Awe to High, you better try again.");
                        ++count;
                        break;
                        //continue;
                    }

                    else if (InputVar < randomNum)
                    {
                        Console.WriteLine("Awe to Low, you better try again.");
                        ++count;
                        break;

                        //continue;
                    }

                    else
                    {
                        Console.WriteLine($"You finally guessed the right number. Yay! The number was {randomNum}!");
                        Console.WriteLine($"It took you {count} tries");
                        Console.ReadLine();
                        LastTask();
                        break;
                    }
                }
            }
        }
    }
}
