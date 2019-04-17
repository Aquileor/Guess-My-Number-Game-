using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class App
    {
        public void Task()
        {
            Console.WriteLine("Hello World");
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