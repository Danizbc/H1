using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Attributes
            //Attributes 

            //Declaring a with value of 32.7
            double a = 32.7;

            //Declaring b with a value of 5.1
            double b = 5.1;

            //Declaring d with value of 9.4
            double d = 9.4;

            //Declaring resault giving value by plus a with b.
            double resault = a + b;
            #endregion

            //Printing out resault.
            Console.WriteLine(resault);
            resault += d;

            //Printing out resault,   a + b + d
            Console.WriteLine(resault);

            

            /* Creating a readkey so console doesnt instanly shutdown 
             *  Console.ReadKey();
             *
             *  I run program by Pressing left-CTRL + F5, thats why Console.ReadKey(); is in the comments.
             */
        }
    }
}
