using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an attribute with no standard value.
            double a;

            //Declaring an attribute with no standard value.
            double b;

            //Declaring an attribute with no standard value.
            double c;

            //Declaring a string With text Enter Value = 
            string text =" Enter Value = ";
            
            //Declaring A true bool.
            bool RunMeWhileTrue = true;


           

            //Running this While RunMeWhileTrue == True
            while (RunMeWhileTrue == true)
            {
                //Printing out string.
                Console.WriteLine("using Pythagoras to calculate (a² + b² = c²)");

                //Trying to do whats inisde try{} if failing Catch will throw message on console.
                try
                {
                    //Printing out text.
                    Console.Write(text);

                    //Convert string from ReadLine to double
                    a = Convert.ToDouble(Console.ReadLine());

                    //Printing out text
                    Console.Write(text);

                    //Convert string from ReadLine to double
                    b = Convert.ToDouble(Console.ReadLine());

                    //math. sqrt return square root of the number.
                    c = Math.Sqrt(a * a + b * b);

                    //Printing out text
                    Console.WriteLine($" Calculation = {c}");


                    //Printing out text
                    Console.WriteLine("\n Do you want to exit now then press [E]");

                    //Making user input by keypress.
                    ConsoleKeyInfo Input = Console.ReadKey();

                    //If you want to exit then press e else keep runniung
                    if (char.ToLower(Input.KeyChar) == 'e')
                    {
                        //Setting RunMeWhileTrue false to exit while loop;
                        RunMeWhileTrue = false;
                    }

                    //clearing console  
                    Console.Clear();
                }

                //Catching all Exception and throwing and message on screen(Should you write a.b.c.d. instead of numbers in convert it throws you here.
                catch (Exception)
                {
                    //print out text
                    Console.WriteLine("You did something wrong... \b Press any key to continue");

                    //Making a readkey so text show before console clearing it down under.
                    Console.ReadKey();

                    //Clearing the console.
                    Console.Clear();
                } 
            }


        }
    }
}
