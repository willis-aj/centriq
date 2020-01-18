using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class LogicComparison
    {
        static void Main()
        {
            Console.WriteLine("Logic and Comparision Operators");

            /*
             * Relational operators compare 2 values and result in a boolean answer of true or false
             * > is greater than
             * < is less than
             * >= is greater than or equal to
             * <= is less than or equal to
            */
            int ceoPayGrade = 20;
            int managerPayGrade = 12;
            int mailroomPayGrade = 2;

            bool isCeoPayHigher = ceoPayGrade > managerPayGrade;
            Console.WriteLine(isCeoPayHigher);

            Console.WriteLine(managerPayGrade < mailroomPayGrade);
            Console.WriteLine(mailroomPayGrade <= ceoPayGrade);

            //if we want to ccheck equality we use ==
            string b1 = "batman";
            string b2 = "BATMAN";
            Console.WriteLine(b1 == b2);

            //if we want to take casing out of the equation we can
            Console.WriteLine(b1.ToUpper() == b2);

            //to check inequality !=
            Console.WriteLine(b1.ToUpper() != b2);

            //logical operators combine 2 or more comparison operatoins
            //or boolean values and return a bool.
            //&& is used for and (& will work but makes the compilier do more, the && means it is "short circuted")
            //|| is used for or (| will work but makes the compilier do more)

            Console.WriteLine(ceoPayGrade > mailroomPayGrade && mailroomPayGrade < 5);

            Console.WriteLine(ceoPayGrade > 25 || managerPayGrade > mailroomPayGrade);
        }//end Main()
    }//end class
}//end namespace
