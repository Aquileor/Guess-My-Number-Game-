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
