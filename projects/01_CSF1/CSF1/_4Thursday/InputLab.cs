using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class InputLab
    {
        static void Main(string[] args)
        {
            /*
            -Ask the user for the following info:
            *Favorite Season
            * Favorite Car
            * Favorite TV Show
            * How much they spent on cable last year
            - Give them a response using all of their info in one statement at the end using string formatting
            -Use currency formatting when you display the cable bill
            */
            
            Console.Write("What is your favorite season? ");
            string season = Console.ReadLine();
            Console.Write("What is your favorite car? ");
            string car = Console.ReadLine();
            Console.Write("What is your favorite TV Show? ");
            string show = Console.ReadLine();
            Console.Write("How much did you spend on cable last year? ");
            string cableBill = Console.ReadLine();
            double cableBillDouble = Convert.ToDouble(cableBill);

            Console.WriteLine("{0} is a great season. {1}'s are a little overrated. " +
                "I love {2}!! {3:c} IS A LOT!!",season,car,show,cableBillDouble);

      
        

        }
    }
}
