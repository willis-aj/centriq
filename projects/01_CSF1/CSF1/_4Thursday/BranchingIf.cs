using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with If");

            /* Flow control
             * interupts the flow of code from top to bottom
             * Branching-how we make decisions in code
             * if statement-ranges
             * switch statement-exact matching
             * 
             * Syntax:
             * if(condition) //required (only one)
             * {
             * //code to run if the condition is true
             * }
             * else if(condition)   //optional (0-00)
             * {
             * //code to run if true
             * }
             * else //optional (if included you can only have 1)
             * {
             * //code to run if none of the ifs are true
             * }
             * 
             * HIS NOTES
             * If allows you to check for a condityion. If that condition is
             * true the code in the body of that if statement is executed.
             * Otherwise, it is skipped
             * 
             * You can optionally add one or more else ifs that will run if their
             * condition is true and no prior condition was met.
             * 
             * You can optionally add a single else statement with no condition
             * that will run if no other statement above it ran.
             */
             
            
            Console.Write("Enter the day of the week: ");
            string day = Console.ReadLine().ToLower();

            if (day == "thursday")
            {
                Console.WriteLine("It's almost the weekend!");
            }//end if
            Console.WriteLine();
            
            Console.WriteLine("In this cave you see bones and white rabbit!");
            int rabbitStrength = 100;
            int heroStrength;
            Console.WriteLine("Enter your attack strength: ");
            //string strengthString = Console.ReadLine();
            heroStrength = Convert.ToInt32(Console.ReadLine());

            if (heroStrength > rabbitStrength)
            {
                Console.WriteLine("You trow the Holy Hand Grenade of Antioch and blow " +
                    "the rabbit to tiny bits!");
            }//end if
            else if (heroStrength == rabbitStrength)
            {
                Console.WriteLine("Alright then. We'll call it a draw.");
            }//end else if
            else if(heroStrength >= (rabbitStrength * .75))
            {
                Console.WriteLine("It's only a flesh wound! You're still alive.");
            }//end else if
            else if (heroStrength > 0)
            {
                Console.WriteLine("The rabbit nibbles your head off.");
            }//end else if
            else
            {
                Console.WriteLine("Were you even trying?");
            }//end else
            //full if tree including 3 else ifs exactly 1 will always run because of the else

            
            //it is common to use a boolean variable a the condition for an if statement:
            bool isAdmin = false;

            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine().ToUpper();

            if (userName == "ABBY" || userName == "ADMIN")
            {
                isAdmin = true;
            }//end if

            if (isAdmin)
            {
                Console.WriteLine("Admin access granted!");
            }//end if
            else
            {
                Console.WriteLine("Access denied.");
            }//end else
            
            //Nested ifs - if trees can be nested within the branches of other trees like this:

            Console.Write("Would you like to know the letter grade for your last test? ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "y" || userChoice == "yes")
            {
                Console.Write("Enter your score out of 100: ");
                byte testScore = Convert.ToByte(Console.ReadLine());
                //mini lab build the functionality to output the letter grade
                if (testScore > 100)
                {
                    Console.WriteLine("invalid score");
                }//end if
                else if (testScore >= 90 && testScore < 100)
                {
                    Console.WriteLine("A");
                }//end else if
                else if (testScore >= 80)
                {
                    Console.WriteLine("B");
                }//end else if
                else if (testScore >= 70)
                {
                    Console.WriteLine("C");
                }//end else if
                else if (testScore >= 60)
                {
                    Console.WriteLine("D");
                }//end else if
                else
                {
                    Console.WriteLine("F. Sorry man.");
                }//end else
                //Console.WriteLine($"Your score was a ");
            }//end if
            else if (userChoice == "n" || userChoice == "no")
            {
                Console.WriteLine("Letter grade not calculated.");
            }//end else if
            else
            {

                Console.WriteLine("That was not a valid option.");
            }//end else
            

            //ternary operators are quick, one line if else statements. (used in the line with other code)
            //Syntax
            //boolean condition ? codeIfTrue : codeIfFalse

            Console.Write("What is your GPA? ");
            float userGPA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("You are {0}.",
                userGPA > 2.5f ? "passing" :"failing");

    

        }//end  Main()
    }//end class
}//end namespace
