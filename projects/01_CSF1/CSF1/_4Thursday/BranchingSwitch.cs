using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with Switch");
            /*
             * Syntax for a switch
             * switch (switch_on)
             * {
             * case Test:
             *      //code
             *      break; //this gets us out of ONLY the switch
             *              if youre missing a break you will get
             *              "control cannot fall through (out if on the default)"
             * case Test:
             *      //code
             *      break;
             * default:
             *      //code
             *      break;
             * }
             * 
            */
            /*
            Console.WriteLine("Choose an option:\n1) Counting\n2) Drawing\n3) water\n4) Change");
            string userChoice = Console.ReadLine().ToLower();
            switch (userChoice)
            {
                case "1":
                case "counting":
                    Console.WriteLine("1, 2, 3, 4, 5, 6 ah ah ah");
                    break;
                case "2":
                case "drawing":
                    Console.WriteLine(@"
    |          ,`
    |\        //
    |\\      //(
    | \\    //  '
    '  \\  //  /
     \  )\((  /
      )`    `/
     /   __  \
    /   (_O)  \
   /           \________
_.(_)           )      /
   (__,        /      /
    \         /      /
     \_______/      (
      \    /         \
       \  /           \
        \/             \
        /               )
       /               /
      / _     o__     /
     ( (_)   //\,\   (
      \    ``~---~`   )
\      \             /
 \      \           /
  \      \         /
   \____/ \_______/ 

");
                
                    break;

                case "3":
                case "water":
                    double gallonWeight = 8.33;
                    Console.Write("How many gallons of water do you have? ");
                    string userGallon = Console.ReadLine();
                    double userGallonNbr = double.Parse(userGallon);
                    Console.WriteLine($"You have {userGallonNbr * gallonWeight} pounds of water.");
                    break;
                case "4":
                case "change":
                    Console.Write("How much money do you have? $");
                    string userMoney = Console.ReadLine();
                    decimal userMoneyNbr = decimal.Parse(userMoney);

                    decimal userMoneyNoQ = userMoneyNbr % .25m;
                    decimal userMoneyAllQ = userMoneyNbr - userMoneyNoQ;
                    decimal userNbrOfQ = userMoneyAllQ / .25m;

                    decimal userMoneyNoQD = userMoneyNoQ % .10m;
                    decimal userMoneyAllD = userMoneyNoQ - userMoneyNoQD;
                    decimal userNbrOfD = userMoneyAllD / .10m;

                    decimal userMoneyNoQDN = userMoneyNoQD % .05m;
                    decimal userMoneyAllN = userMoneyNoQD - userMoneyNoQDN;
                    decimal userNbrOfN = userMoneyAllN / .05m;

                    decimal userNbrOfP = userMoneyNoQDN / .01m;

                    Console.WriteLine("You have {0} Quarters, {1} Dimes, " +
                        "{2} Nickels, and {3} Pennies.", userNbrOfQ, userNbrOfD,
                        userNbrOfN, userNbrOfP);
                    break;
                default:
                    Console.WriteLine("hey dumbdumb pick one of the options I offered.");
                    break;
            }//end switch
            */

            Console.WriteLine("Choose an option:\n1) Counting\n2) Drawing\n3) water\n4) Change");
            string userChoice = Console.ReadLine().ToLower();
            switch (userChoice)
            {
                case "1":
                case "counting":
                    Console.WriteLine("1, 2, 3, 4, 5, 6 ah ah ah");
                    break;
                case "2":
                case "drawing":
                    Console.WriteLine("What picture would you like?\n1) rabbit\n2) astronaut\n3) Grim Reaper" +
                        "\n4) fairy\n5) yoda (sorry he isnt a baby)");
                    string user2Choice = Console.ReadLine().ToLower();
                    switch (user2Choice)
                    { 

                        case "1":
                        case "rabbit":

                            Console.WriteLine(@"
                                        |          ,`
                                        |\        //
                                        |\\      //(
                                        | \\    //  '
                                        '  \\  //  /
                                            \  )\((  /
                                            )`    `/
                                            /   __  \
                                        /   (_O)  \
                                        /           \________
                                    _.(_)           )      /
                                        (__,        /      /
                                        \         /      /
                                            \_______/      (
                                            \    /         \
                                            \  /           \
                                            \/             \
                                            /               )
                                            /               /
                                            / _     o__     /
                                            ( (_)   //\,\   (
                                            \    ``~---~`   )
                                    \      \             /
                                        \      \           /
                                        \      \         /
                                        \____/ \_______/ 

");
                        break;
                        case "2":
                        case "astronaut":
                            Console.WriteLine(@"
                         .-.
                         '-'
                        //
               _..---._/|
             .' .'     '-.
            / __ /          \      *
           ==== _____     __ |     :
          /#   #''' |   /()\    :    ..*
          |#   #    |   \__/    : .''
          \#___#____|      /   :::.. .
           \______________ | _...‰_: .. '*
  ()       // /\||||)))))))      '   . .
 .( \_     \\_\//   _-'.'/        |   * ..
( ) |^|^|^| ooo / _#\.//''''_      |   . . .
(_)_.'v|v|v|     / \#  \_ / '_  _'    . .
           | _ _ / _ /     / './_-|'         . .
           /#_#__'''-._ /#  \__)       .  .
           | __   '' -._ |##               . . .
           | '' | -'''-_/##              . .
           / ''--\__.-|                       .
           \-_.-< __ /                   .   .
           / -_ | /  \
           \-_ | \_ -<.                        .  .
           < _ -/ < _.-\                    .
           < _ -|  | _.-|                        .
      .---- |   \__\  |                 .
     |     .'''   '.  |                       .
      .___ |        | __ | (c)NamelessOne
          '.__...'''


");
                        break;
                        case "3":
                        case "Grim Reaper":
                            Console.WriteLine(@"
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

");
                        break;
                        case "4":
                        case "fairy":
                            Console.WriteLine(@"
      {\       _____     ,
     {* \     (*~*~*)   /}
    { ~ *\    ////^^\  /~}
    {*    \  (((/ 6 6 / *}
    {  * ~ \ )))c  = )*  }
     {*   * ////'_/~` ~ }
      {~ * (((( `.`\ *}' .:.
       `{.~ )))`\ \))_.-:<*>:-
          `{ (() `\_.-'` `:'
            `)/ `. |
  jgs        (    \'
              \    \
          _  __`\   |
        |` `'   ``Y  ;
        | /``-../  /
        `'      | /
                / `-._
                `-----'
");
                        break;
                        case "5":
                        case "yoda":
                            Console.WriteLine(@"
                    ____
                 _.' :  `._
             .-.'`.  ;   .'`.-.
    __      / : ___\ ;  /___ ; \      __
  ,'_ ''--.:__;'.-.';: :'.-.':__;.--'' _`,
  :' `.t''--.. ' <@.`; _  ',@>` ..--''j.' `;
       `:-.._J '-.-'L__ `--' L_..-;'
         '-.__ ;  .-'  '-.  : __.-'
             L ' /.------.\ ' J
              '-.   '--'   .-'
             __.l'-:_JL_;-';.__
          .- j / '.;  ;""""  / .'\'-.
           .' /:`. '-.:     .-' .';  `.

");
                        break;
                    default:
                        Console.WriteLine("You dont like following instructions, do you? JACQUE!");
                        break;
                    }//end of nested switch
                    break;

                case "3":
                case "water":
                    double gallonWeight = 8.33;
                    Console.Write("How many gallons of water do you have? ");
                    string userGallon = Console.ReadLine();
                    double userGallonNbr = double.Parse(userGallon);
                    Console.WriteLine($"You have {userGallonNbr * gallonWeight} pounds of water.");
                    break;
                case "4":
                case "change":
                    Console.Write("How much money do you have? $");
                    string userMoney = Console.ReadLine();
                    decimal userMoneyNbr = decimal.Parse(userMoney);

                    decimal userMoneyNoQ = userMoneyNbr % .25m;
                    decimal userMoneyAllQ = userMoneyNbr - userMoneyNoQ;
                    decimal userNbrOfQ = userMoneyAllQ / .25m;

                    decimal userMoneyNoQD = userMoneyNoQ % .10m;
                    decimal userMoneyAllD = userMoneyNoQ - userMoneyNoQD;
                    decimal userNbrOfD = userMoneyAllD / .10m;

                    decimal userMoneyNoQDN = userMoneyNoQD % .05m;
                    decimal userMoneyAllN = userMoneyNoQD - userMoneyNoQDN;
                    decimal userNbrOfN = userMoneyAllN / .05m;

                    decimal userNbrOfP = userMoneyNoQDN / .01m;

                    Console.WriteLine("You have {0} Quarters, {1} Dimes, " +
                        "{2} Nickels, and {3} Pennies.", userNbrOfQ, userNbrOfD,
                        userNbrOfN, userNbrOfP);
                    break;
                default:
                    Console.WriteLine("hey dumbdumb pick one of the options I offered.");
                    break;
            }//end switch



        }//end Main()
    }//end class
}//end namespace
