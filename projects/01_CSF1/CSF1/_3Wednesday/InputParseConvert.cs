using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class InputParseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing, and converting");

            #region Input/Output Notes
            /*
             * There are 2 options for output of inforamtion to the console window: Write() and WriteLine()
             * WriteLine() adds a line break after your output. Write() does not
             * 
             * There are 3 options for capturing input from a user:
             * Read() - Captures a single keystroke of input and captures the ascii value of the key
             * ReadKey() - Captures a single keystroke of input and captures the character value
             * ReadLine() - Allows the user to input as much information as necessary and captures it as a string when the user hits enter
             * 
             * When utilizing ReadLine() to capture input you have to either store the resulting string in a string variable or
             * you have to use it immediately, otherwise the string is lost.
             * 
             * STEPS TO USE READLINE()
             * Step 1 - Explain to the user what to type.
             * Step 2 - Allow them to type using the ReadLine()
             * Step 3 - Capture the information or use it immediately
             */
            #endregion

            Console.Write("What is your name? ");//step 1
            string userName = Console.ReadLine();//step 2 and 3
            Console.WriteLine("Hello, " + userName + "!"); //using the variable

            Console.Write("What is your quest?");
            Console.WriteLine(Console.ReadLine() + " is a silly quest...");

            //MINI-LAB!
            //Ask the user for their favorite color. Tell them their colour back and what you think of it. Use their name in your response

            Console.Write("What is your favorite color?");
            Console.WriteLine(Console.ReadLine() + " is a great color " + userName + "!");

            Console.Write("What city are you from? ");
            string userCity = Console.ReadLine();
            //string formating uses 0-based indexes as placeholders where values are inserted at runtime.
            Console.WriteLine("{0} is great, {1}! I love {0}", userCity, userName);
            /* System.FormatException is the error you will get if you are missing
             * one of the values. if you get a system.formatexception error look 
             * at the line number it is crashing on (found in the bottom right corner
             * of the console) and go check that line. 
             * 
             * If it is the line you have the string on it is probably something 
             * wrong with the syntax or variables check the it is a 0 and not O,
             * check that you have the same number of variables at the end that 
             * you have in the line.
             * 
             * If it is a different line make sure the input from the user is the
             * correct variable type. ex line 88-89 if someone put twelve instead of 12 it is
             * not able to be made into an int.
             */
          
            //Because ReadLine() returns a string we must change that data into 
            //another datatype if we wat to use it as something other than a string.
            //one option for this is parsing.
            //syntax:
            //datatype.Parse(stringValue);

            /*NOTES on strings stuff
             * there are 3 ways to combine values with strings
             * 
             * 1. concatenation
             *          this is done with a + and "" around just the string
             * 2. string formating
             *          this uses 0 based indexs as place holders and then the
             *          variable sit at the end of the string ex line 51
             * 3. String interpolation
             *          this uses value based placeholders with a $ before the
             *          string ex line 94
             */
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);
            int yearsTo100 = 100 - age;
            Console.WriteLine("Only {0} more years until you're 100!", yearsTo100);

            Console.Write("Enter your current salary: $");
            string userSalary = Console.ReadLine();
            decimal salary = decimal.Parse(userSalary);
            Console.WriteLine($"Unfortunately, {salary * .3m} will go to federal taxes.");
            //this last line is string interpolation

            /*
             * All of the datatypes that we've used so far have C# reserved 
             * keywords associated with them which are simply a shortcut syntax
             * that points to a class behind the scenes in the .Net framework.
             * Usually you can use either the keyword or the class name:
             * 
             * byte = Byte
             * short = Int16
             * int = Int32
             * long = Int64
             * decimal = Decimal
             * double = Double
             * float = Single
             * string = String
             * bool = Boolean
             * char = Char
             * 
             * When using convert you have to use the class name instead of the shortcut.
             * SYNTAX for convert
             * Convert.ToClassName(valueToConvert);
            */

            Console.WriteLine("How many times have you dined at Devin's Pizza? ");
            string mealsString = Console.ReadLine();
            short meals = Convert.ToInt16(mealsString);
            Console.WriteLine($"You get a free pizza in {10-meals} more visits.");



        }//end Main()
    }//end class
}//end namespace
