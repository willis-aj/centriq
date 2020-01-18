using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Operators
    {
        static void Main()
        {
            Console.WriteLine("Mathmatical Operators");
            Console.WriteLine(3 + 5); //addition
            Console.WriteLine(12 - 8); //subtraction
            Console.WriteLine(11 * 2); //multiplication
            Console.WriteLine(10 / 5); // division

            int legos = 15 + 27;
            Console.WriteLine(legos);

            //assume a legocar takes 9 legos to build how many cars can you build?
            int legoCars = legos / 9;//division
            Console.WriteLine(legoCars);
            //there are 6 left over, how do we show it? Modulous. will give you remainder


            //Modulous
            int remainingPieces = legos % 9;
            Console.WriteLine(remainingPieces);

            // we have 75 nails and it takes 30 nails to build a dresser, how many dressers can be built and how many nails are left over?
            int nails = 75;
            int nailsRequired = 30;
            int dressersBuilt = nails / nailsRequired;
            int nailsRemaining = nails % nailsRequired;
            Console.WriteLine("We can build " + dressersBuilt + " dressers and there will be " + nailsRemaining + " nails left over.");

            //MINI-LAB! There are 100 cookies and 47 students. Assuming each student gets the same number of cookies and no partial cookies. How many
            //cookies would each student get and how many would be left over.
            int cookies = 100;
            int students = 47;
            int cookiesPerStudent = cookies / students;
            int cookiesRemaining = cookies % students;
            Console.WriteLine("Each student can have " + cookiesPerStudent + " cookies and there will be " + cookiesRemaining + " cookies left over.");

            //Unary operators are used to quikly increment or decrement a numeric value.
            //When incrementing or decrementing values you can either us the unary or you can write it out the long way:
            int coffeeMugs = 2;
            //Long way:
            coffeeMugs = coffeeMugs + 1;
            Console.WriteLine(coffeeMugs + " coffee mugs in stock.");

            //Unary operator: only increments or decrements by 1
            coffeeMugs++;
            Console.WriteLine(coffeeMugs + " coffee mugs in stock.");

            //long way
            coffeeMugs = coffeeMugs - 1;
            Console.WriteLine(coffeeMugs + " coffee mugs in stock.");

            //unary operator
            coffeeMugs--;
            Console.WriteLine(coffeeMugs + " coffee mugs in stock.");

            //this is refered to as a POST-FIX incrementer because the unary operator is after the variable that it modifies.

            //Mathematical assignment operators combine a mathematical calculation with an assignment to quickly do math on a variable's values and reassign
            //the result back to that variable:
            //+=,-=,*=,/=,%=

            int totalWords = 2;
            Console.WriteLine("Total words: " + totalWords);

            //long way to add 4:
            totalWords = totalWords + 4;
            Console.WriteLine("Total words: " + totalWords);

            //shortcut:
            totalWords += 4;
            Console.WriteLine("Total words: " + totalWords);

            //long way multiply by 3
            totalWords = totalWords * 3;
            Console.WriteLine("Total words: " + totalWords);

            //shortcut
            totalWords *= 3;
            Console.WriteLine("Total words: " + totalWords);

            //MINI-LAB!
            //divide by 3 both the long and short way showing your answer each time.
            //long way divide by 3
            totalWords = totalWords / 3;
            Console.WriteLine("Total words: " + totalWords);

            //shortcut
            totalWords /= 3;
            Console.WriteLine("Total words: " + totalWords);

            //subtract 2 both the long and short way showing your answer each time.
            //long way subract 2
            totalWords = totalWords - 2;
            Console.WriteLine("Total words: " + totalWords);

            //shortcut
            totalWords -= 2;
            Console.WriteLine("Total words: " + totalWords);

            //modulus by 2 using only the shortcut and show your final answer
            //shortcut
            totalWords %= 2;
            Console.WriteLine("Total words: " + totalWords);
            //if even would be 0 if odd would be 1 meaning 
            //modulus by 2 will tell you if a number is even.
            Console.WriteLine(688 % 2);//even
            Console.WriteLine(99 % 2);//odd



        }//end Main()
    }//end Class
}//end namespace
