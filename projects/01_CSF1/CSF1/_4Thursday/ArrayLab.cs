using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class ArrayLab
    {
        static void Main(string[] args)
        {
            /*
             * - Ask the user for 5 scores (1 at a time)
               Display the high, low, and average score

               The scores should be ones from a test, like 0 - 100

               TIP: To figure out the average, add all of the values together and divide by the total number of values

               HINT: Sorting an array puts the items in a different order
             * 
             */

            int[] scores = new int[5];
            Console.WriteLine("Enter your 5 scores as whole numbers:");
            scores[0] = Convert.ToInt32(Console.ReadLine());
            scores[1] = Convert.ToInt32(Console.ReadLine());
            scores[2] = Convert.ToInt32(Console.ReadLine());
            scores[3] = Convert.ToInt32(Console.ReadLine());
            scores[4] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(scores);
            Console.WriteLine($"Your lowest score is {scores[0]}");

            Console.WriteLine($"Your highest score it {scores[4]}");

            int totalScores = scores.Sum();
            Console.WriteLine($"Your average is {totalScores/5}");

            

            





        }
    }
}
