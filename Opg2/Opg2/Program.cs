using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attribute

            //Declaring double with name reamur, no standard value.
            double reamur;

            //Declaring double with name fahrenheit, no standart value.
            double fahrenheit;

            //Declaring double with name  celcius, no standart value.
            double celcius;

            //print out text, \n make new line
            Console.Write("Calculate Reamur & Fahrenheit \n Input Celcius = ");
            
            /*
             * Giving you option to Input Char/String number and convert them to double, input any text like A,B,C and it wil give an error.
             * by making a try catch inside a while loop would you could make a debug.
             */
            celcius = double.Parse(Console.ReadLine());

            //Print out Reamur & Fahrenheit all calculated.
            Console.WriteLine($"\n Reamur = {reamur = (celcius * 0.8)} \n Fahrenheit = {fahrenheit = (celcius * 1.8 +32) } ");


           

        }
    }
}
