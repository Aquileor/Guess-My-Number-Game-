using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Implement_bisection_algorithm
    {

        public static int NumberGenerator()

        {

            Random random = new Random();

            int numbers = random.Next(1, 10);

            return numbers;

        }

        public static int NumberList()

        {

            int[] Numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };

            return Numbers[NumberGenerator()];

        }

        public void FirstTask()
        {
            
           while (true)
            {
                int randomNum = NumberList();

                int count = 1;

                while (true)
                {
                    Console.WriteLine($"Guess a number that has to be between 1 and 10.\n(If you want to quit at any time press 0)."); //\nThe new range is {randomNum}
                    Console.Write("\nMy Number is: ");


                    int InputVar = Convert.ToInt32(Console.ReadLine());
                    if (InputVar == 0)

                        return;

                    else if (InputVar > randomNum)
                    {
                        Console.WriteLine("\nAwe to High,you better try again.");
                        ++count;

                        continue;
                    }

                    else if (InputVar < randomNum)
                    {
                        Console.WriteLine("\nAwe to Low, you better try again.");
                        ++count;

                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"You finally guessed the right number. Yay! The number was {randomNum}!");
                        Console.WriteLine($"It took you {count} tries");

                        break;
                    }
                }
            }

        }
    }
}
