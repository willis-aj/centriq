using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Monday
{
    class Variables
    {
        static void Main(string[] args)
        {
            #region Notes from day 1 that were taken before we started coding
            /*Notes from day 1 that were taken before we started coding
             * .Net Overview- it is a Microsoft framework used to solve software development problem.
             * a frame work is a set of tools and resourses used to solve a problem
             * FCL-Framework Class Library-this is the drawers of the tool box and the Classes are the actual tools we use.
             *  3 applications are made with .Net:Web applications, Desktop applications and Web services. see line 72-76
             * mainly used on windows. .Net is like a mini OS, it is fairly self contained. There is multi-language support via the Common Type System (CTS)
             * CTS converts any language into binary so they can all talk to each other and the machine
             *.Net has less going on behind the scenes because it messes less with the system registry.
             * Because of that it has easier versioning (the ability to work on the next version of code while the current one is being used).
             * .Net is managed code. This means the framework will do somethings that make the programmers life easier like "garbage collecting"
             * getting rid of unnecessary things? data? when it is not being used
             * .Net has built in security - not for complicated things can still have issues but most basic security issues are guarded against
             *
             * Object Oriented Programing- on day 2 quiz, in OOP you can re use tools, you are able to store the information  time and use it over and over
             *later in this document this is used with the variables.
             * 
             * C# Overview
             * C# is a language written specifically for .Net and it is OOP
             * C# is managed by .Net (see line 23) and is designed to be managed by .Net
             * it is syntactically similar to Java, C++ and PHP, because they are all C based languages
             * Functional stuff about C#:
             * Case sensitive
             * Uses {} called curly brases or skopes
             * semicolons ; are like periods, must be at the end of the line of code
             * Largely ignores white space- this is so that humans can read the code better and does nothing for the computer.
             * Typesafe- If info has a data type it will not be changed by the code or by the programmer later.
             * files have an extension of .cs
             * 
             * data type is the kind of data you have (string for text or int for numbers) and what data type a piece of data is will determine
             * what can be done with it see line 118-121
             * 
             * Visual Studio Overview
             * Visual Studio is an IDE (Integrated Development Environment), this means it is a piece of software that make writing and running
             * applications easier. It is easier to write a C# program in and IDE than it is to write it in notepad.
             * File management works like this I need to fix lots of things at my house. The solution is the store home depot, the projects are the isles,
             * and the classes are the objects for sale. Solution is the application (ex amazon.com, ebay.com), projects (at least 1 per solution),
             * classes (at least 1 per projects)
             * projects=namespace=assembly
             * BENEFITS-
             * File management
             * color coding-for human readabilty
             * intellisense-autocomplete ish
             * debugging help tools
             * compiling- this allows you to write the code and run it in the same place unlike if you were to write it in notepad and move it to a compiler
             * pre-compiler-checks things and marks with a squigle under it if you need to check something like missing something or havent used something
             * NOT SPELL CHECKING
             * toolbars and panels because it is a window application so it looks like a windows application
             * 
             * 
            */
            #endregion
            #region Notes on comments, method, vs, .net, running a program
            //adding // at the start of a line creates a single-line comment that will be ignored by the compiler.

            //The Main() (read main method) is where the C# application starts to execute 

            //In Visual Studio the solution is the collection / portfolio of projects.
            //The projects are like a roadmap that details how different pieces of functionality relate to each other.

            //.Net supports 3 kinds of applications:
            //1. Desktop/Windows applications-these are applications that run on the machine where the code is stored. (ex minecraft or VS)
            //2. Web Applications-these are applications that run in web browsers. The code lives on a different machine than where its run. (called "website")
            //3. Web Services- these are distributed applications that are not fully functional by themselves but are instead called into other apps.
            // ie widgets on a website
            //webSITE vs webAPPLICATION
            //A webSITE is static. This is what webpages looked like in the early 90's. The page would look the same no matter who was looking at it or where
            //they were.
            //A webAPPLICATION is dynamic. This is what webpages look like today. amazon.com looks different to me than it does to someone else and it looks
            //different to me than to someone looking at it in india.

            //3 steps to running a program
            //1. Save (CTRL + S) green line to the left
            //2. Build (CTRL + SHIFT + B) build started bottom left corner then build succeeded
            //3. Run(CTRL + F5)
            //Performing a run executes all 3 steps
            #endregion

            Console.WriteLine("Hello, world!");
            #region Notes on multi-line comments and variables
            /*
             * This is a multi-line comment.
             * 
             * A variable is just a container designed to store information. Just like any other container
             * its contents can be changed. Because C# is a type-safe language all variables must have a datatype
             * assigned to them at creation.
             * The datatype cannot be changed programmatically (in the code).
             * 
             * Declaration, initialization, and assignment
             * 
             * Declaration means creating the variable, making the box. This requires a datatype and a name.
             * Initialization means giving it a value for the first time, fill the box the first time.
             * Assignment means giving it a value at any time, fill the box any time.
             */
            #endregion
            string name; //declaration

            name = "Abigayle Willis"; //initialization
            Console.WriteLine(name);
            Console.WriteLine(name);

            name = "Evan Lavender"; //assignment
            Console.WriteLine(name);

            //code runs top to bottom and that means Abigayle Willis still shows up for the first 2 while evan is the third

            //We can also declare and initialize on the same line:

            int number = 12345; //declaration and initialization
            Console.WriteLine(number); //int
            Console.WriteLine("12345" + 8); // string (cant do math with this line) concatenation (+8) the whole thing turns into a string
            Console.WriteLine(12345 + 8); //int will do the math

            // Using the + operator on numbers results in addition. Using it on a string results in a string via concatenation.

            int chiefsPoints = 51;
            int texansPoints = 31;

            Console.WriteLine("The Chiefs scored " + chiefsPoints + " sports points in the last game.");
            Console.WriteLine("Total game points: " + (chiefsPoints + texansPoints));

            int nflTeams = 32;
            string kcTeams = "Chiefs";
            //MINI-LAB! Write a sentence to the screen using both of the above variables:
            Console.WriteLine("There are " + nflTeams + " teams in the NFL, and the team in Kansas City is the " + kcTeams + ".");

            //Constants are like variables whose value can never change. You must assign a value at declaration. That value can never change.

            const int MEANING_OF_LIFE = 42;

            Console.WriteLine("The meaning of life is " + MEANING_OF_LIFE);




        }
    }
}
