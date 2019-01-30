using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._456
{
    class Gui
    {

        /// <summary>
        /// Printing out 1-10 and 10-1
        /// </summary>
        public void PrintCountingString()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        //Printing out text and return input
        public double UserInputReturnX(double input, bool RunUntillDone)
        {
            //while loop so it run again if it fail.
            while (RunUntillDone == false)
            {
                //Trying to covert readline to double.
                try
                {
                    Console.Clear();
                    Console.Write("I need you to give me a number to my calculation, x + 32 - 297.\nWrite Number = ");
                    input = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    RunUntillDone = true;

                }
                //Catch error 
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong, please try again.\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
            //Returning output
            return input;
        }

        //Get input and result and pring out text
        public void TheResultGui(double input, double result)
        {
            Console.Clear();
            Console.WriteLine($"The result of {input} + 32 - 297 = {result}");
        }

    }
}
