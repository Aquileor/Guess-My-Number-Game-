using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aquileo Reyes
//04 April 2019
//Guess My Number Game (Bisection Algorithm) 

namespace GuessMyNumberGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Write a console application implementing the bisection algorithm. 
            //new Implement_bisection_algorithm().FirstTask();

            //Implement a version of Guess My Number, where the computer randomly chooses a number between 1 and 1000, and the human guesses the number. 
            //new Guess_my_number_human_plays().MiddleTask();

            //Implement a version of Guess My Number, where the human chooses a number between 1 and 100, and the computer guesses the number.

            Console.WriteLine("The number you input between 1 and 10 is the number the computer has to guess.\n(If you want to quit at any time press 0):");
            Console.Write("\nEnter a random number for the computer to guess: ");

            int randomNum = Convert.ToInt32(Console.ReadLine());
            //new Guess_my_number__computer_plays().LastTask();


            new ThisIsRandomTestCodes().Play();
        }
    }
}

