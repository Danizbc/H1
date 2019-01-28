using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //index 0, 0 = students name, index 0,1 = students grade
            Students[,] GroupOfStudens = new Students[2, 10];


            float average = 0;


            bool runWhileTrue = true;

            //Creating object of students and adding to the array of students.
            for (int i = 0; i < GroupOfStudens.GetLength(0); i++)
            {

                for (int j = 0; j < GroupOfStudens.GetLength(1); j++)
                {
                    GroupOfStudens[i, j] = new Students(i);
                }
            }

            //Counting how many groups
            for (int i = 0; i < GroupOfStudens.GetLength(0); i++)
            {
                Console.Clear();

                //counting how many students
                for (int j = 0; j < GroupOfStudens.GetLength(1); j++)
                {
                    bool runMeWhileTrue = true;

                    while (runMeWhileTrue == true)
                    {

                        Console.Write($"Enter the grades Group {i} student {GroupOfStudens[i, j].Name.ToString()}\nGrades = ");

                        //trying to add grades into object student
                        try
                        {
                            GroupOfStudens[i, j].Grade = Convert.ToSingle(Console.ReadLine());

                            Console.Clear();
                            runMeWhileTrue = false;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Something went wrong.\nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                }
                Console.WriteLine($"Group {i} graded.\nPress any key to continue");
                Console.ReadKey();
            }

            //running switch case inside a while loop, so user can pick wich option he want to use.
            while (runWhileTrue == true)
            {

                Console.Clear();
                Console.Write("Press [P] to print out all students with grades.\n\nPress [A] to show average grades of both groups.\n\nPress [x] to EXIT.\n\n Press key = ");

                ConsoleKeyInfo input = Console.ReadKey();
                switch (char.ToLower(input.KeyChar))
                {
                    case 'p':

                        for (int i = 0; i < GroupOfStudens.GetLength(0); i++)
                        {
                            for (int j = 0; j < GroupOfStudens.GetLength(1); j++)
                            {
                                Console.Clear();
                                Console.WriteLine($"{GroupOfStudens[i, j].Name} {GroupOfStudens[i, j].LastName} \ngrade = {GroupOfStudens[i, j].Grade}\n\n Press any key to continue");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case 'a':
                        Console.Clear();
                        for (int i = 0; i < GroupOfStudens.GetLength(1); i++)
                        {
                            average += GroupOfStudens[0, i].Grade;
                        }
                        average = average / GroupOfStudens.GetLength(1);
                        Console.WriteLine($"Group 0, average grades = {average}\n");



                        for (int i = 0; i < GroupOfStudens.GetLength(1); i++)
                        {
                            average += GroupOfStudens[1, i].Grade;
                        }
                        average = average / GroupOfStudens.GetLength(1);
                        Console.WriteLine($"Group 1, average grades = {average}.\n\nPress any key to continue.");
                        Console.ReadKey();
                        break;
                    case 'x':
                        runWhileTrue = false;
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
