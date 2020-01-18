using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            #region Array notes
            /*
             * Arrays are a collection of material, unlike variables we have used so far
             * there are lots of variable not just one.
             * 
             * declare this with data type and name
             * datatype is data type from before plus []
             * ex string[] dresser = new String[4];
             * "string [4]" is a constructor whos job it is to build the array
             * after that line the array is built but the drawers are still empty
             * 
             * NOTE string[] is not string if you try to build string[] test = "test" it freaks out
             * 
             * Array properties
             * indexes are 0.based
             * typesafe-if it is string[] then only string can go in it
             * fixed length-once they are assigned a number of how indexes will always have
             *          that number of indexes
             * use the "new" keyword to construct them
             * Length is 1.based-Length is last index
             * 
             * 
             * ikia dresser-this is the array built below on line 56
             *              string [] dresser
             * dresser[0]   "shirts"
             * dresser[1]   "pants"
             * dresser[2]   "shorts"
             * dresser[3]   "socks"
             * cant give more drawers or less drawers once built
             * can leave one drawer empty
             * 
             * 
             * HIS NOTES
             * Arrays store fixed-length collections of data of the same type.
             * 
             * Features:
             * typesafe
             * indexes are 0-based
             * fixed Length (1 based)
             * Complex data types (we use the new keyword to call the constructor)
             */
            #endregion
            string[] dresser = new string[4];
            dresser[0] = "shirts";
            dresser[1] = "pants";
            dresser[2] = "shorts";
            dresser[3] = "socks";

            Console.WriteLine("{0} are in the top drawer and {1} are in the bottom drawer.",
                dresser[0], dresser[3]);

            //mini lab
            //write the next to last index to the screen using string interpolation
            Console.WriteLine($"{dresser[2]} are in the 3rd drawer.");

            Console.WriteLine(dresser.Length);

            Console.WriteLine($"{dresser[0]} | {dresser[dresser.Length - 1]}");
            //collections are usually called plural version of things
            decimal[] prices = new decimal[5];
            prices[0] = 5.23m;
            prices[1] = 72m;
            prices[2] = 1.19m;
            prices[3] = 274m;
            prices[4] = .15m;//if you use too many indexes it will get an index out of range error
                             //if you call to an index that has not been initialize it will give default if possible

            //decimal totalSale = prices[0] + prices[1] + prices[3] + prices[4];
            // Console.WriteLine("{0:c}", totalSale);

            decimal totalSale = prices.Sum();
            Console.WriteLine("{0:c}", totalSale);

            Console.WriteLine($"{prices[0]:c} | {prices[prices.Length - 1]:c}");

            //Sort() is called from the array class. It sorts the indexes
            //of the specified array in order from lowest to highest for
            //numerics or A-Z for alphas. It is referred to as an ascending sort.
            //syntax:
            //array.sort(array to sort)

            Array.Sort(prices);
            Console.WriteLine($"{prices[0]:c} | {prices[prices.Length - 1]:c}");

            //reverse() inverts all of the indexes of the specified array. when used
            //after sort() it sorts items in descending order
            Array.Reverse(prices);
            Console.WriteLine($"{prices[0]:c} | {prices[prices.Length - 1]:c}");

            //declare and initialize at the same time
            //You can both declare and initialize an array in thesame statement using
            //"collection initialization syntax"
            string[] tools = {"wrench","hammer","jack","air compressor","pliers"};
            Console.WriteLine(tools[3]);

            //minilab!
            //using collection initialization syntax declare and initialize a string
            //array of foods. show one of the food items in your console:

            string[] food = {"pizza", "cheese", "candy" };
            Console.WriteLine(food[2]);










        }//end Main()
    }//end class
}//end namespace
