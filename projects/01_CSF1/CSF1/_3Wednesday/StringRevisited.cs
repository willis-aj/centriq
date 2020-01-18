using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class StringRevisited
    {
        static void Main()
        {
            //the ToString() returns the string version of any variable of any datatype. It is useful for 
            //applying format specifiers to values that are not strings.
            
            Console.WriteLine("Manipulating Strings");
            decimal number = 124154.2392m;
            Console.WriteLine(number);
            Console.WriteLine(number.ToString());
            Console.WriteLine(number.ToString("n"));
            Console.WriteLine(number.ToString("n1"));
            Console.WriteLine(number.ToString("n6"));
            Console.WriteLine(number.ToString("c"));
            Console.WriteLine(number.ToString("e"));
            Console.WriteLine($"{number:c}"); // only for output makes it look like money

            string numberString = number.ToString("n"); //for storing this info as a string
            Console.WriteLine(numberString);

            int wholeNumber = 52;
            Console.WriteLine(wholeNumber.ToString("n3"));

            //escape sequences are special characters uses inside of strings that ignore other characters. In C# they begin with a \
            //\n creates a new line inside of the string
            Console.WriteLine("I love escapes!\nThey are easy");

            //\" escapes the " and treats it as a character
            Console.WriteLine("\"I like turtles!\" said Zombie Kid.");

            //\\ escapes the escape
            Console.WriteLine("C:\\VisualStudio2017\\Projects\\CSF1");

            //\u#### gives you a unicode character
            Console.WriteLine("It feels like it's 100\u00B0 in here.");
            //www.utf8-chartable.de this is the website that has all the unicode characters in a table
            //Console.WriteLine("\a"); //windows alert sound gets played

            //Verbatim character is similar to an escape in that it treats all characters, including spacing and like breaks
            //literally (except quotes).
            string nonsense = @"
Hey, there!

My name is Cortana, and I'm here to help!


You can find the files you need at
                          C:USers/student/VS2017
";
            Console.WriteLine(nonsense);

            string grimReaper = @"
               ...
             ;::::;
           ;::::; :;
         ;:::::'   :;
        ;:::::;     ;.
       ,:::::'       ;           OOO\
       ::::::;       ;          OOOOO\
       ;:::::;       ;         OOOOOOOO
      ,;::::::;     ;'         / OOOOOOO
    ;:::::::::`. ,,,;.        /  / DOOOOOO
  .';:::::::::::::::::;,     /  /     DOOOO
 ,::::::;::::::;;;;::::;,   /  /        DOOO
;`::::::`'::::::;;;::::: ,#/  /          DOOO
:`:::::::`;::::::;;::: ;::#  /            DOOO
::`:::::::`;:::::::: ;::::# /              DOO
`:`:::::::`;:::::: ;::::::#/               DOO
 :::`:::::::`;; ;:::::::::##                OO
 ::::`:::::::`;::::::::;:::#                OO
 `:::::`::::::::::::;'`:;::#                O
  `:::::`::::::::;' /  / `:#
   ::::::`:::::;'  /  /   `#


";//from asciiart.website
            Console.WriteLine(grimReaper);


        }
    }
}
