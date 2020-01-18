using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class ChangeLab
    {
        static void Main()
        {
            /*
             * Write a program that will:
             * 
             * Prompt the user to enter an amount of dollars and cents. For example: 1.18
             * Display the number of quarters, dimes, nickels, and pennies to make that amount.
             * 
             * 
             * take input divide as an int by .25 should give me number of quarters
             * 
             * 
             * Ex. If they entered 1.18 it should say:
             *  4 quarters, 1 dimes, 1 nickels, 3 pennies
             *  
             * Ex. If they entered 2.02 it sould say:
             *  8 quarters, 0 dimes, 0 nickels, 2 pennies
             *  
             * Complete the water lab FIRST!
             * 
             * HINT: Break it into small problems
             */
            #region Attempt 1
            /*
            Console.Write("How much money do you have? $");
            string userMoney = Console.ReadLine();
            double userMoneyNbr = double.Parse(userMoney);
            
            double quartersDouble = userMoneyNbr / .25;
            string quartersString = quartersDouble.ToString("n0");
            double quartersDoubleNoDecimal = Convert.ToDouble(quartersString);

            double userMoneyNbrNoQ = userMoneyNbr - (quartersDoubleNoDecimal * .25); //quarters are taken out

            //double dimesDouble = userMoneyNbrNoQ / .1;
            //string dimesString = dimesDouble.ToString("n0");
            //double dimesDoubleNoDecimal = Convert.ToDouble(dimesString);






            Console.WriteLine(quartersString);



            //Console.WriteLine($"{quartersDouble:0} quarters, ");

    */

            #endregion

            
            Console.Write("How much money do you have? $");
            string userMoney = Console.ReadLine();
            decimal userMoneyNbr = decimal.Parse(userMoney);

            decimal userMoneyNoQ = userMoneyNbr % .25m;
            decimal userMoneyAllQ = userMoneyNbr - userMoneyNoQ;
            decimal userNbrOfQ = userMoneyAllQ / .25m;

            decimal userMoneyNoQD = userMoneyNoQ % .1m;
            decimal userMoneyAllD = userMoneyNoQ - userMoneyNoQD;
            decimal userNbrOfD = userMoneyAllD / .1m;

            decimal userMoneyNoQDN = userMoneyNoQD % .05m;
            decimal userMoneyAllN = userMoneyNoQD - userMoneyNoQDN;
            decimal userNbrOfN = userMoneyAllN / .05m;

            decimal userNbrOfP = userMoneyNoQDN / .01m;




            Console.WriteLine("You have {0} Quarters, {1} Dimes, {2} Nickels, and {3} Pennies.", userNbrOfQ, userNbrOfD, userNbrOfN, userNbrOfP);

            /*
             * could have used new assignment for userMoneyNbr then you could
             * have reused it because it exicutes from top down.
             * 
             * Try that here
             */

            /*
            Console.Write("How much money do you have? $");
            string userMoney = Console.ReadLine();
            decimal userMoneyNbr = decimal.Parse(userMoney);

            userMoneyNbr = userMoneyNbr % .25m;
            decimal userMoneyAllQ = userMoneyNbr - userMoneyNbr;
            decimal userNbrOfQ = userMoneyAllQ / .25m;
            */



            Console.WriteLine(userMoneyNbr);





        }
    }
}
