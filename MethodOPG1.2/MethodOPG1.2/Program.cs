using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Class logic.
            Logic logic = new Logic();

         //Creating loop so it run untill set to false.
            while (logic.RunWhileTrue == true)
            {
                //Trying to convert readline into double, if fail it will catch it and throw error message that something went wrong.
                Console.Clear();
                try
                {
                    Console.WriteLine("This program are made to calculate Pythagoras");
                    Console.Write("Input number a = ");
                    logic.InputOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input number b = ");
                    logic.InputTwo = Convert.ToDouble(Console.ReadLine());
                    logic.RunWhileTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong try again.\n\nPress any key to continue.");
                    Console.ReadKey();
                }
            }

            //Printing out Pythagoras by running method logic.Pythagoras inside class called logic
            Console.WriteLine($"Result = {logic.Pythagoras()}");

            //Running Bool method to see if a is bigger than b
            if (logic.BiggestNumber() == true)
            {
                Console.WriteLine("Input a is bigger than b");
            }
            else
            {
                Console.WriteLine("Input B is bigger than A");
            }

            //Readkey so we have something to read, just kidding, to end program GG
            Console.ReadKey();
        }
    }
}
