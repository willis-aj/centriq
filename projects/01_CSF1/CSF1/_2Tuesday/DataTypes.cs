using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Data Types: Bob Sure Is Loving");
            #region new data types
            /* New types of data for numbers
             *        Type          Bits Needed         Range
             *Bob     byte          8                   0-255 byte is unsigned and unsigned data types cannot hold negative values
             *          sbyte       8                   -128-127 this one is signed byte
             *Sure    short         16                  ~-32k-~32k signed
             *        ushort        16                  0-~64k unsigned
             *Is      int           32                  ~-2.14bil-~2.14bil
             *        uint          32                  0-~4.28bil
             *Loving  long          64                  ~-9quintilion-~9quint
             *        ulong         64                  0-~18quin
             * int is default
             * deciding what type of number to use is based on what is useful now and the amount of storage available and what will happen in the future.
             * ex. storing test scores should be byte, because score will never be less than 0 and prob wont be over 100 so there is no need to use
             * a larger datatype like int or long to store that information. Also we should take into account what will happen in the future.
             * we will probably not change how we grade peoples tests to shapes or colors so the number data type will continue to work. Also we
             * will not assign more than 100% so we dont have to worry about the number getting too big to be a byte.
             * 
             * ex. Storing population of countries should be larger than int because the population of india is at over 1 billion right now so if 
             * we were to create a program that stored the population of countries and it was storing indias population when it 2.14 billion
             * and 1 more it would crash. In this way we have to think about the future with the applications we build.
             */
            #endregion
            // iterative code: making small piece of code and checking that it compiles and runs then moving on
            byte byteNbr;
            byteNbr = 0;
            byteNbr = 255;

            short shortNbr;
            shortNbr = -1236;
            //MINI-LAB declare and initialize an int and a long:

            int intNbr;
            intNbr = 5452;
            long longNbr;
            longNbr = 45218854;

            //MINI-LAB declare and initialize the alternate datatypes:

            sbyte sbyteNbr = -87;
            ushort ushortNbr = 256;
            uint uintNbr = 5643;
            ulong ulongNbr = 284511575;

            //floating point types represent fractional values (what humans think of as decimals) when math is done with floating numbers there is
            //precision that is lost
            float fractionOne = 12.95f; //32 bits can store 45 digits total before and after the decimal. the f after the number here is important because
            //the compiler sees 12.95 as a double and wont let you call it a float unless you add the f after the number f can be F or f
            double fractionTwo = 98.49; //64 bits can store, 324 digits. *default floating point type* more precise than float
            decimal fractionThree = 52.68m; //128 bits can store 29 digits (less digits because it is most precise). the m is after the number for the (M or m) 
                                            //same reason the f is after the float one
                                            //Datatype selection depends on what you are using it for. 
                                            //data type selection depends on what you need. If you were working with something where you need a high degree of
                                            //precision like money you should use decimal. If it is something that can be less precise like maps, like
                                            //the distance between here and st louis you can use the float because it uses less space and will be ok if
                                            // it is less precise.

            //char accepts a single (ONLY ONE) character value in single quotations:
            char letter = 'f';
            char character = '%';

            Console.WriteLine(fractionTwo);
            Console.WriteLine(character);

            //bool (boolean) stores a single value of true or false:
            bool isVerified = false;
            isVerified = true;
            Console.WriteLine(isVerified); //displays exact word true or false, may not be readable for the user



            #region notes from day 3 on data types
            /*
             * above here are all simple/ intringsic data types
             * these are all prebuilt into .Net, Store a single value (ie 1 number one character)
             * are a fixed size, and are stored on the Stack.
             * 
             * Complex data types can store multiple values, they are expandable so the size is not fixed, Stored on the heap.
             * 
             */
            #endregion

        }//end Main() comment the closing curly braces so we can see that we closed every open one at the type
    }//end Class
}//end Namespace
