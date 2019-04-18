using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class ThisIsRandomTestCodes
    {


private int high_low(int guess, int high, int low)
    {
        return (high - low) / 2;
    }

    static int Main()
    {
        RandomNumbers.Seed((int)time(null));
        int random = 1 + RandomNumbers.NextNumber() % 1000;
        int guess = 1000;
        int counter = 0;
        int low = 0;
        int high = 0;

        Console.Write("Random #");
        Console.Write(random);
        Console.Write("\n");

        while (guess != random && counter++ < 10)
        {
            Console.Write("Guess # ");
            Console.Write(counter);
            Console.Write(" number: ");
            Console.Write(guess);
            Console.Write("\n");

            if (guess > random)
            {
                Console.Write("Lower...\n");
                high = guess;
                guess = high_low(guess, high, low) + low;
            }
            else
            {
                Console.Write("Higher...\n");
                low = guess;
                guess += high_low(guess, high, low);
            }
        }
        Console.Write("Number you guessed is: ");
        Console.Write(guess);
        Console.Write(" in ");
        Console.Write(counter);
        Console.Write(" tries");

        Console.Read();
        Console.Read();
        return 0;
    }



    internal static class RandomNumbers
    {
        private static System.Random r;

        public static int NextNumber()
        {
            if (r == null)
                Seed();

            return r.Next();
        }

        public static int NextNumber(int ceiling)
        {
            if (r == null)
                Seed();

            return r.Next(ceiling);
        }

        public static void Seed()
        {
            r = new System.Random();
        }

        public static void Seed(int seed)
        {
            r = new System.Random(seed);
        }
    }

}
}

/*
 * int highestguess = 101;
int lowestguess = 0;
int range = 100;
int offset = 1;

Then modify the computation line to be.

computerNumber = rand() % range + offset;

Then when you guess the number, update the guess numbers and then rang/offset when needed.

if (computerNumber > secretNumber)
{
	cout << "The computer has guessed too high!\n\n";
	highestguess = computerNumber;
	range = highestguess - lowestguess - 1;
	++tries;
}
else if (computerNumber < secretNumber)
{
	cout << "The computer has guessed too low!\n\n";
	lowestguess = computerNumber;
	range = highestguess - lowestguess - 1;
	offset = lowestguess + 1;
	++tries;
}
*/
