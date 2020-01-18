using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class DataTypesLab
    {
        static void Main()
        {
            /*
             * Declare and initialize variables of 10 different data types
             * Use at least:
             * 1 string
             * 1 whole number type
             * 1 floating point type
             * 1 bool
             * 1 char
             * 
             * Display each of them with a Console.WriteLine();
             * Additionally, create two variables - one that uses the min and one that uses the max value for at least one whole number type
             * and display them.
            */
            string name = "Abigayle Willis";
            Console.WriteLine("Name: " + name);
            int fingers = 10;
            Console.WriteLine("Fingers: " + fingers);
            byte toes = 10;
            Console.WriteLine("Toes: " + toes);
            double grade = 87.5;
            Console.WriteLine("Grade: " + grade);
            bool isGoing = true;
            Console.WriteLine("Is going:" + isGoing);
            char gradeLetter = 'B';
            Console.WriteLine("Grade letter: " + gradeLetter);
            int daysAtCentriq = 2;
            Console.WriteLine("Has been at Centriq for " + daysAtCentriq + " days.");
            long daysUntilWedding = 1028;
            Console.WriteLine("Days until wedding: " + daysUntilWedding);
            string weddingColors = "Lavender and Yellow";
            Console.WriteLine("Wedding colors: " + weddingColors);
            bool isExcited = true;
            Console.WriteLine("Is Excited: " + isExcited);

            sbyte min = -128;
            Console.WriteLine("sbyte min = " + min);
            byte max = 255;
            Console.WriteLine("byte max = " + max);








        }//end Main()
    }//end class
}//end namespace
