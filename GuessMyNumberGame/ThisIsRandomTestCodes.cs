using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace GuessMyNumberGame
{
    class ThisIsRandomTestCodes
    {
        public int randomNum { get; private set; }

        static int CompGuess(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public void Play()
        {
          
                //Console.WriteLine("The number you input between 1 and 10 is the number the computer has to guess.\n(If you want to quit at any time press 0):");
                //Console.Write("\nEnter a random number for the computer to guess: ");

                //int randomNum = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    //FirstStep();

                    int guess = CompGuess(1, 10);

                    int count = 1;

                    int InputVar = guess;
                    Console.Write($"\nThe computer guessed the Number: {guess}\n");


                    while (true)
                    {
                        if (InputVar == 0)

                            return;

                        else if (InputVar > randomNum)
                        {
                            Console.WriteLine("Awe to High, you better try again.");
                            //++count;
                         count = InputVar + 1;
                        //LowerLim = iCompNum + 1
                        //Play();

                       return;



                       //      continue;
                        }

                        else if (InputVar < randomNum)
                        {
                            Console.WriteLine("Awe to Low, you better try again.");
                        //++count;
                        count = InputVar - 1;
                        //randomNum = randomNum / 2;


                        return;
                        //continue;
                    }

                        else
                        {
                            Console.WriteLine($"You finally guessed the right number. Yay! The number was {randomNum}!");
                            Console.WriteLine($"It took you {count} tries");
                            Console.ReadLine();
                        Play();
                            break;
                        }

                    }
                }
            }
        

        /*
        public void Play()
        {
            const int from = 1;
            const int to = 10;

            int randomNumber = new Random().Next(from, to);
            int guessedNumber;

            Console.Write("The number is between {0} and {1}. ", from, to);
            while (true)
            {
                Console.Write("Make a guess: ");
                if (int.TryParse(Console.ReadLine(), out guessedNumber))
                {
                    if (guessedNumber == randomNumber)
                    {
                        Console.WriteLine("You guessed the right number!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too {0}.", (guessedNumber > randomNumber) ? "high" : "low");
                    }
                }
                else
                {
                    Console.WriteLine("Input was not an integer.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        */
    }
}

/*
private int _tmain(int argc, _TCHAR[] argv)
{
    RandomNumbers.Seed(time(null));

    int tries = 0;
    int iNum;
    int UpperLim = 100;
    int LowerLim = 1;
    int iCompNum;

    Console.Write("\tWelcome to Guess My Number\n\n");
    Console.Write("in this version, the computer tries to guess YOUR number\n\n\n");

    Console.Write("Enter a number: ");
    iNum = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

    do
    {
        iCompNum = RandomNumbers.NextNumber() % (UpperLim - LowerLim) + LowerLim;

        Console.Write("\nComputer's guess: ");
        Console.Write(iCompNum);
        ++tries;

        if (iNum > iCompNum)
        {
            Console.Write("\nYou're too low..!\n\n");
            LowerLim = iCompNum + 1;
        }
        else if (iNum < iCompNum)
        {
            Console.Write("\nToo high..!\n\n");
            UpperLim = iCompNum - 1;
        }
        else if (iNum == iCompNum)
        {
            Console.Write("\nYou got my number, You're the man!\n\nYou guessed the number in just ");
            Console.Write(tries);
            Console.Write(" tries!\n\n");
        }

    } while (iNum != iCompNum);

    return 0;
}
*/







