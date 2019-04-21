using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass()]
    public class Guess_my_number_human_plays

    {

        [TestMethod()]
        public void MiddleTask()
        {
            while (true)
            {
                int randomNum = 33;

                int count = 1;

                while (true)
                {

                    int InputVar =33;
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