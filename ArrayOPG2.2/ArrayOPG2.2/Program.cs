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

            List<string> maleNames = new List<string> { "Anders", "Andreas", "Alias", "bent", "Benny", "Børge", "Bubber", "Casper", "Daniel", "Danny", "Eric", "Emil", "Aberon", "Frodo", "Frede", "Gunnert", "Gert", "Haris", "Henrik", "Ivan" };
            List<string> femaleNames = new List<string>();


            //Creating a char with name search
            char searchChar = ' ';

            string searchName = "";

            //creating a string with name Press any that contain a text
            string PressAny = "Press any key to continue.";

            //Creating a bool called run while true, setting it to true.
            bool runWhileTrue = true;

            //Sorting my list in alphabeatic order
            maleNames.Sort();

            //Creating while loop running until set to false.
            while (runWhileTrue == true)
            {
                Console.Clear();
                Console.WriteLine("Do you want to search for name or print all names? \n\nPress [S] to search.\n\nPress [P] to print all names.\n\nPress [R] to remove names.\n\nPress [A] to add names.\n\nPress [X] to EXIT...");
                //making a keyinfo for user to input keyword without having to use enter all the time.
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();
                //making a switch case with chars, s  p x.
                switch (char.ToLower(input.KeyChar))
                {
                    case 's':
                        Console.WriteLine("Press [M] for males names.\n\nPress [F] for female names.");
                        input = Console.ReadKey();

                        //Creating a bool called correct, if any crash comes along try catch will make program keep running, throwing error message and letting user try again.
                        bool correct = false;
                        while (correct == false)
                        {
                            Console.Clear();
                            Console.Write("Press the letter you want to search for.\n\nWrite letter = ");
                            //Trying to convert readline to char.
                            try
                            {
                                searchChar = Convert.ToChar(Console.ReadLine());
                                correct = true;
                            }
                            //If any error comes it get catch here and throw error message to user.
                            catch (Exception)
                            {

                                Console.WriteLine("Only one letter are allowed");
                                Console.WriteLine(PressAny);
                                Console.ReadKey();
                            }

                        }
                        //Checking if input.keychar is m, to print out male names.
                        if (char.ToLower(input.KeyChar) == 'm')
                        {
                            //Getting lengt of list of malenames. checking if any of the name contain the letter user inputted above.
                            for (int i = 0; i < maleNames.Count; i++)
                            {
                                //For loop that run until the count of male names..
                                if (maleNames[i].ToLower().IndexOf(searchChar) != -1)
                                {
                                    Console.WriteLine(maleNames[i]);
                                }
                            }
                        }
                        //Checking if input.keychar is f to pront out female names.
                        else if (char.ToLower(input.KeyChar) == 'f')
                        {
                            //For loop run untill it reach the count of female names.
                            for (int i = 0; i < femaleNames.Count; i++)
                            {
                                if (femaleNames[i].ToLower().IndexOf(searchChar) != -1)
                                {
                                    Console.WriteLine(femaleNames[i]);
                                }
                            }
                        }
                        Console.WriteLine($"\n{PressAny}");
                        Console.ReadKey();
                        break;

                    //print out all maleNames in the array.
                    case 'p':
                        //Pinting out all male names in the list
                        Console.WriteLine("Male names");
                        for (int i = 0; i < maleNames.Count; i++)
                        {
                            Console.WriteLine(maleNames[i]);
                        }
                        //Printing out all the Female names that counted. 
                        Console.WriteLine("\n\nFemale names");
                        for (int i = 0; i < femaleNames.Count; i++)
                        {
                            Console.WriteLine(femaleNames[i]);
                        }

                        Console.WriteLine($"\n{PressAny}");
                        Console.ReadKey();
                        break;

                    case 'r':

                        //Giving user option to pick female or male by using ConsoleKeyInfo input = Console.ReadKey();
                        Console.WriteLine("Write [F] for Female.\n\nWrite [M] for male.");
                        input = Console.ReadKey();
                        //Making a reagion so i can collaps it.
                        #region MaleSection


                        //Checking if input from user is f or m. 
                        if (char.ToLower(input.KeyChar) == 'm')
                        {
                           //Checking if any list contain anything.
                            if (maleNames.Count == 0)
                            {
                                Console.WriteLine($"No males in the list.\n{PressAny}");
                                Console.ReadKey();
                            }
                            else
                            {

                                //Running for loop that looping untill it reach counted names in the list.
                                for (int i = 0; i < maleNames.Count; i++)
                                {
                                    Console.WriteLine($"{maleNames[i]} ID = {i}");

                                }

                                Console.Write("What name do you want to remove?\n\nWrite [0101] to return.\n\nInput ID = ");
                                //trying to convert readline into and into storing it, in a int temp,
                                try
                                {
                                    //if user want to exit their giving the option to write 0101 to exit or else write the id of the name they wish to remove.
                                    int temp = Convert.ToInt32(Console.ReadLine());
                                    if (temp == 0101)
                                    {

                                    }
                                    else
                                    {
                                        Console.Clear();

                                        Console.WriteLine($"You removed {maleNames[temp]}");
                                        //removing name at index[temp]
                                        maleNames[temp] = null;

                                        //sorting the list
                                        maleNames.Sort();

                                        Console.WriteLine($"\n{PressAny}");

                                        Console.ReadKey();
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine($"Something went wrong \n{PressAny}");
                                    Console.ReadKey();
                                }
                            }
                        }
                        #endregion
                        //Making a reagion so i can collaps it.
                        #region Female section'
                        //Checking if user pressed the key f.
                        else if (char.ToLower(input.KeyChar) == 'f')
                        {

                            Console.Clear();
                            //Checking if the list contains anything.
                            if (femaleNames.Count == 0)
                            {
                                Console.WriteLine($"No female in the list.\n{PressAny}");
                                Console.ReadKey();
                            }
                            //Runing this if list contain any names.
                            else
                           {
                                //Running for loop to find all names in string list of female names.
                                for (int i = 0; i < femaleNames.Count; i++)
                                {

                                    Console.WriteLine($"{femaleNames[i]} ID = {i}");

                                }
                                //trying to convert Readline to int, if fail catch will throw error message to user.
                                try
                                {
                                    Console.Write("What name do you want to remove?\n\nWrite [0101] to return.\n\nInput ID = ");
                                    int temp = Convert.ToInt32(Console.ReadLine());
                                    if (temp == 0101)
                                    {

                                    }
                                    else
                                    {
                                        Console.Clear();

                                        Console.WriteLine($"You removed {femaleNames[temp]}");
                                        //removing that name user picked
                                        femaleNames[temp] = null;

                                        //Sorting the list
                                        femaleNames.Sort();

                                        Console.WriteLine($"\n{PressAny}");

                                        Console.ReadKey();
                                    }
                                }
                                //Catch errors and print out message at screen
                                catch (Exception)
                                {
                                    Console.WriteLine($"Something went wrong \n{PressAny}");
                                    Console.ReadKey();
                                }
                            }
                        }
                        #endregion
                        break;

                    case 'a':
                        //Made to add names to male of female list.
                        Console.WriteLine("Add to list.\nPress [M] for male.\nPress [F] for female.");
                        //Giving user option to add Female of Male name.
                        input = Console.ReadKey();
                        Console.Clear();
                        Console.Write("Write name to add.\nWrite name = ");
                     
                        if (char.ToLower(input.KeyChar) == 'm')
                        {
                            //Giving user option to write name that they wish to add.
                            maleNames.Add(Console.ReadLine());
                        }
                        else if (char.ToLower(input.KeyChar) == 'f')
                        {
                            //Giving user option to write name that they wish to add.
                            femaleNames.Add(Console.ReadLine());
                        }
                        break;

                    case 'x':
                        runWhileTrue = false;
                        //ending the loop exiting program.
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
