using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class WaterLab
    {
        static void Main()
        {
            /*
             * Write a program that will:
             * 
             * Assume that a gallon of water weighs 8.33 pounds
             * Prompt the user to enter a number of gallons
             * Display the total weight of the water in pounds
             * 
             * Test with something simple like 2 to start so that you can verify the math is correct.
             * 
             */
             
            double gallonWeight = 8.33;
            Console.Write("How many gallons of water do you have? ");
            string userGallon = Console.ReadLine();
            double userGallonNbr = double.Parse(userGallon);
            Console.WriteLine($"You have {userGallonNbr * gallonWeight} pounds of water.");
        

        }

    }
}
