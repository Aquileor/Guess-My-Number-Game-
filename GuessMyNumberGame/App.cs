using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class App
    {

        static int NumRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public void Task()
        {
            while (true)
            {
                int randomNum = NumRange(1, 10);

                int count = 1;

                while (true)
                {
                    Console.WriteLine("Guess a number that has to be between 1 and 10.\n(If you want to quit at any time press 0):");
                    Console.Write("\nMy Number is: ");


                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;

                    else if (input > randomNum)
                    {
                        Console.WriteLine("Awe to High, you better try again.");
                        ++count;

                        continue;
                    }

                    else if (input < randomNum)
                    {
                        Console.WriteLine("Awe to Low, you better try again.");
                        ++count;

                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"You finally guessed the right number. Yay! The number was {randomNum}!");
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }
   
    }
}



// * >> int value = 7;
//>> int[] list = {1,2,3,4,5,6,7,8,9,10};
//>> bisection_search(value, list); 
//<< value is higher than 5 
//    //the ‘‘middle’’ value is 5.5, but we are doing integer division 
//    //the list is now set to {6,7,8,9,10} 
//>> bisection_search(value, list); 
//<< value is lower than 8 
//    //the middle value is 8 
//    //the list is now set to {6,7} 
//>> bisection_search(value, list); 
//<< value is higher than 6 
//    //the ‘‘middle’’ value is 6.5, but we are doing integer division 
//    //the list is now set to {7} 
//>> bisection_search(value, list); 
//<< value is equal to 7 
//    //the middle value is 7 
//    //the list is now set to {7} 
//<< the value searched for, 7, has been found 


/*private void btnGuess_Click(object sender, EventArgs e)
{
bool guess = true;
Convert.ToInt32(txtNumber.Text); // don't need this line
nrToGuess = int.Parse(txtNumber.Text);
DialogResult dialogResult;

do
{
average = (minimum + biggest) / 2;
dialogResult= MessageBox.Show("Is your number" + " " + average+ " ? ", "Question", MessageBoxButtons.YesNo);
if (dialogResult== DialogResult.No && average > nrToGuess)
{
biggest = average;
average = (biggest + minimum) / 2;
}
else if (dialogResult == DialogResult.No && average < nrToGuess)
{
minimum = average;
average = (biggest + minimum) / 2;
}
else if (dialogResult == DialogResult.Yes)
{
dialogResult=MessageBox.Show("Congratulations! You guessed the number!");
break;
}
else
{
Application.Exit();
}
}
while (guess);


    */


/*
 * 
 * 
 *  public static double Bisection_method (MyFun fun , double start , double 
end, double? guess)
{
    if ( fun(start) * fun(end) > 0 )
    {
        Console.WriteLine("wrong Entry");
        return -1;
    }

    double avg,tolerance,sign;

    avg = (guess.HasValue) ? guess.Value : ( (start + end) / 2 );
    do
    {
        tolerance = Math.Abs ( fun(end) - fun(start) );

        sign = fun(start) * fun(avg);
        if (sign < 0)
            end = avg;
        else if (sign > 0)
            start = avg;
        else
        {
            if (fun(start) == 0)
                return start;
            else return end;
        }

        avg = (start + end) / 2;
    }
    while ( tolerance > 0.0001 );

    return end;
}

    */