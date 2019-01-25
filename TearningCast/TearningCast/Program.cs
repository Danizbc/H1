using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearningCast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Method  with name ran.
            Random ran = new Random();

            //Creating methid to input char.
            ConsoleKeyInfo Input;

            //Creating bool true or false
            bool runMeWhileTrue = true;

            //Looping as long runMeWhileTrue is == true;
            while (runMeWhileTrue == true)
            {
                //Clearing the console.
                Console.Clear();

                //Printing out text
                Console.WriteLine("\n Press R to roll the dize \n\n Press E to exit");

                //Making user input by keypress into a char
                Input = Console.ReadKey();

                //Char.ToLower converts input.keychar to small char. If statement check if input == R
                if (char.ToLower(Input.KeyChar) == 'r')
                {
                    //Clearing Console
                    Console.Clear();

                    //making the text color blue.
                    Console.ForegroundColor = ConsoleColor.Blue;

                    //Making the console background color blue. i used it as comment because i dont like chaning background color.
                    //Console.BackgroundColor = ConsoleColor.Blue;

                    //Printing out text
                    Console.WriteLine($"The dize landed on {ran.Next(1, 7)} \n\n Press any key to continue.");

                    //Readkey so we can see the resault before exiting if statement.
                    Console.ReadKey();

                    //resseting the color to orginal color.
                    Console.ResetColor();

                }
                //Checking if input == small char 'e'. by converting input from player to small char
                else if (char.ToLower(Input.KeyChar) == 'e')
                {
                    //Ending the loop if player write e
                    runMeWhileTrue = false;
                }
                //Run if any of other statement isnt true!
                else
                {
                    //clearing the console
                    Console.Clear();

                    //Printing out text.
                    Console.WriteLine("Wrong input try again. \n \n  Press any key to continue.");

                    //Readkey so we can see the result before exiting the  else statement
                    Console.ReadKey();
                }

            }
            

        }
    }
}
