using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting access to class calculator by creating calc
            Calculator Calc = new Calculator();

            Console.WriteLine("This Program will devide two numbers, find modus & power and print it to you.");
            //Adding two values of double to calc.input and calc.inputtwo
            while (Calc.RunWhileTrue == true)
            {
                try
                {
                    Console.Write("Please input first number.\nNumber = ");
                    Calc.Input = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please input secound number.\nNumber = ");
                    Calc.InputTwo = Convert.ToDouble(Console.ReadLine());
                    Calc.RunWhileTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Something went wrong.");
                }
                
       
            }

            //Printing out 2 numbers devided, by running Calc.Devider Method
            Console.WriteLine($"numbers devided  = {Calc.Devider()}");
            //Printing modus of the 2 numbers by running method Calc.Modus method
            Console.WriteLine($"Modus = {Calc.Modus()}");
            //Printing out power of 2 numbers inputted by running Calc.Potensenss method
            Console.WriteLine($"Potensens = {Calc.Potensenss()}");

            Console.ReadKey();
        }
    }
}
