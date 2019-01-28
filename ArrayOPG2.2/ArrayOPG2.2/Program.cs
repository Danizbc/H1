using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Properties

            //making array of names with capacity from 0-19 = 20 index avaible
            string[] maleNames = new string[20] {"Anders", "Andreas", "Alias", "bent", "Benny", "Børge", "Bubber", "Casper", "Daniel", "Danny", "Eric", "Emil", "Aberon", "Frodo", "Frede", "Gunnert", "Gert", "Haris", "Henrik", "Ivan"   };
            
            //Creating a char with name search
            char search = ' ';

            //creating a string with name Press any that contain a text
            string PressAny = "Press any key to continue.";

            //Creating a bool called run while true, setting it to true.
            bool runWhileTrue = true;

            //Sorting my list in alphabeatic order
            Array.Sort(maleNames);

            //Creating while loop running until set to false.
            while (runWhileTrue == true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to search for name or print all names? \n\nPress [S] to search.\n\nPress [P] to print all names.\n\nPress [X] to EXIT...");
                //making a keyinfo for user to input keyword without having to use enter all the time.
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                //making a switch case with chars, s  p x.
                switch (char.ToLower(input.KeyChar))
                {
                    case 's':
                      
                        //Creating a bool called correct, if any crash comes along try catch will make program keep running, throwing error message and letting user try again.
                        bool correct = false;
                        while (correct == false)
                        {
                            Console.Clear();
                            Console.Write("Press the letter you want to search for.\n\nWrite letter = ");
                            try
                            {
                                search = Convert.ToChar(Console.ReadLine());
                                correct = true;
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Only one letter are allowed");
                                Console.WriteLine(PressAny);
                                Console.ReadKey();
                            }
                            
                        }

                        //Getting lengt og array of malenames. checking if any of the name contain the letter user inputted above.
                        for (int i = 0; i < maleNames.Length; i++)
                        {

                            if (maleNames[i].ToLower().IndexOf(search) != -1)
                            {
                                Console.WriteLine(maleNames[i]);
                            }
                                        
                          

                        }
                        Console.WriteLine($"\n{PressAny}");
                        Console.ReadKey();
                        break;

                        //print out all maleNames in the array.
                    case 'p':
                        for (int i = 0; i < maleNames.Length; i++)
                        {
                            Console.WriteLine(maleNames[i]);

                        }
                        Console.WriteLine($"\n{PressAny}");
                        Console.ReadKey();
                        break;

                    case 'x':
                        runWhileTrue = false;
                        break;

                    default:
                        Console.WriteLine($"Something went wrong. \n{PressAny}");
                        Console.ReadKey();
                        break;
                } 
            }



          
        }
    }
}
