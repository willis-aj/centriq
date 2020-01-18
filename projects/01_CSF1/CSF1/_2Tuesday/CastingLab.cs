using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class CastingLab
    {
        static void Main()
        {
            //some variables to use
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000;
            long ocean = 5;
            /*
             * 1. cast the value of the lake into the ocean and display it
             * 2. cast the value of the pond into the puddle and display it
             * 3. cast the value of the pond into the ocean and display it
             * 4. cast the value of the ocean into the lake and display it
             * 
             * for each casting, include a comment categorizing it as
             * implicit casting
             * explicit casting
             * explicit casting with truncation
             */
             //implicit
            ocean = lake;
            Console.WriteLine("lake into ocean " + ocean);
            //explicit trucation
            puddle = (byte)pond;
            Console.WriteLine("pond into puddle " + puddle);
            //implicit
            ocean = pond;
            Console.WriteLine("pond into ocean " + ocean);
            //explicit
            lake = (int)ocean;
            Console.WriteLine("ocean into lake " + lake);





        }//end Main()
    }//end class
}//end namespace
