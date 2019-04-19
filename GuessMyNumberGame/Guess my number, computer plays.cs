

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Guess_my_number__computer_plays
    {
        public int randomNum { get; private set; }

        static int CompGuess(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

     
        

        public  void LastTask()
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
                        ++count;
                        randomNum = randomNum / 2;
                        LastTask();
                        return;
                      


                       // continue;
                        }

                        else if (InputVar < randomNum)
                        {
                            Console.WriteLine("Awe to Low, you better try again.");
                        ++count;
                        //randomNum = randomNum / 2;



                        continue;
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


/*
from random import randint

print ("In this program you will enter a number between 1 - 100."
       "\nAfter the computer will try to guess your number!")

number = 0

while number < 1 or number >100:
    number = int(input("\n\nEnter a number for the computer to guess: "))
    if number > 100:
        print ("Number must be lower than or equal to 100!")
    if number < 1:
        print ("Number must be greater than or equal to 1!")

guess = randint(1, 100)

print ("The computer takes a guess...", guess)

while guess != number:
    if guess > number:
        guess -= 1
        guess = randint(1, guess)
    else:
        guess += 1
        guess = randint(guess, 100)
    print ("The computer takes a guess...", guess)

print ("The computer guessed", guess, "and it was correct!")
*/