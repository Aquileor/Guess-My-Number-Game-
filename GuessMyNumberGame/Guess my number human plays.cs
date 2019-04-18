using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Guess_my_number_human_plays
    {
        static int NumRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public void MiddleTask()
        {
            while (true)
            {
                int randomNum = NumRange(1, 10);

                int count = 1;

                while (true)
                {
                    Console.WriteLine("Guess a number that has to be between 1 and 1,000.\n(If you want to quit at any time press 0):");
                    Console.Write("\nMy Number is: ");


                    int InputVar = Convert.ToInt32(Console.ReadLine());
                    if (InputVar == 0)

                        return;

                    else if (InputVar > randomNum)
                    {
                        Console.WriteLine("Awe to High, you better try again.");
                        ++count;

                        continue;
                    }

                    else if (InputVar < randomNum)
                    {
                        Console.WriteLine("Awe to Low, you better try again.");
                        ++count;

                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"You finally guessed the right number. Yay! The number was {randomNum}!");
                        Console.WriteLine($"It took you {count} tries");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
        }

    }
}
