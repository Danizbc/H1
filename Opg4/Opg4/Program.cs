using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring double with name h.
            double h;
            //Declaring double with name b.
            double b;
            //Declaring double with name l.
            double l;
            //Declaring double with name result.
            double result;
            
            //Print out text new line
            Console.WriteLine("This machine will calculate volume of a box");


            //print out text, making next input after the text instead of making new line.
            
            Console.Write("Input height of box = ");
            // convert input numer from readline to double.
            h = Convert.ToDouble(Console.ReadLine());

            //Print out text, making next input after the text instead of making new line.
            Console.Write("Input the width of the box = ");
            // convert input numer from readline to double.
            b = Convert.ToDouble(Console.ReadLine());

            //Print out text, making next input after the text instead of making new line.
            Console.Write("Input the length of the box = ");
            // convert input numer from readline to double.
            l = Convert.ToDouble(Console.ReadLine());

            //Calculated h, b, l
            result = ( h * b * l );

            //Print out text, making next input after the text instead of making new line.
            Console.WriteLine($"The volume of the box = {Math.Round(result, 4)}");

            Console.ReadKey();
            switch (switch_on)
            {
                default:
            }

        }
    }
}
