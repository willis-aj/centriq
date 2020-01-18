using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Casting
    {
        static void Main()
        {
            //to get stuff to run correctly you need to run the right project and the right class
            //to get correct class right click project name>properties>startup project>drop down>pick correct class
            //to get correct project right click on solution>set startup projects>single startup>drop down>pick correct solution
            Console.WriteLine("Casting");
            #region Casting notes
            /*
             * Casting is copying the value from a variable of one datatype into a variable of a similar but different type. There are two kinds of
             * Casting: implicit and explicit. Implicit casting-copying the value of a smaller datatype into a larger datatype. this always works w/o issue
             * explicit casting - copying the value of a larger datatype into a smaller datatype. this can cause probs if the value wont fint.
             * bigger or smaller is dependent on the number of bits
            */
            #endregion
            #region how numbers are stored in binary
            /* 32768  16384  8192  4096  2048  1024  512  256  128  64  32  16  8  4  2  1
             * 0      0      0     0     0     0     0    0    0    0   0   0   0  0  0  0   this is 0
             * 1      0      0     0     0     0     0    0    0    0   0   0   0  0  0  0   this is 32768
             * 0      1      1     1     1     1     0    1    0    0   0   0   0  0  0  0   this is 32000
             * 0      0      0     0     0     0     1    0    0    0   1   1   0  0  0  0   this is 560
             * 0      1      1     1     1     1     1    0    0    0   0   0   0  1  0  1   this is 32261 see line 41 and 53-54 when we took 32261 from
             *                                                                               line 40 and made it a byte in line 52 it turned into the next
             *                                                                               line because it drops the bits past 256 because thats all the
             *                                                                               bigger a byte can be. This is called truncation.
             *                                            0    0    0   0   0   0  1  0  1   this displays as 5  
             *                                                                               5 this is the byte amount of info from 32261
             */                                                                               
            #endregion
            byte toothpasteBox = 1;
            short shoeBox = 200;
            int movingBox = 32261;
            long fridgeBox;

            //implicit casting
            fridgeBox = toothpasteBox;
            Console.WriteLine(fridgeBox);
            Console.WriteLine(toothpasteBox);

            //Explicit casting
            toothpasteBox = (byte)shoeBox;
            Console.WriteLine(toothpasteBox);
            //Explicit casting with truncation

            toothpasteBox = (byte)movingBox;
            Console.WriteLine(toothpasteBox);

            //MINI-LAB Cast the long into the int and display it. Make a comment catergorizing it as implicit, explicit, or explicit with truncation.
            //explicit
            movingBox = (int)fridgeBox;
            Console.WriteLine(movingBox);


            //MINI-LAB! Cast the long into the byte and categorize it like before. cast the short into the int and categorize it.
            toothpasteBox = (byte)fridgeBox; //explicit
            movingBox = shoeBox; //implicit




        }//end Main ()
    }//end class
}//end namespace
