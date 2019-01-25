using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderOPG
{/// <summary>
/// Creating Gui class to keep my strings sorted
/// </summary>
    class Gui
    {
        //Properties

        //creating private string that can only be read and not edited, only by editing here before running program.
        private readonly string errorCode = "Age require numbers not letters, Press any key to try again.";

        private readonly string nameString = "Write your birth name. \n Input name = ";

        private readonly string ageString = "How young are you. \n Input age = ";

        private readonly string diaprtext = "you are allowed to go with diaper.";

        private readonly string dadText = "you are not allowed to do anything!";

        private readonly string momText = "you are allowed to drink.";

        private readonly string allGrownText = "you are allowed to vote and drive.";

        private readonly string govermentLie = "system say you can still work, no pension for you!";




        //method to print text, input name and age send it to logic where object Human is created.
        public void NameAndAge(Human user, bool RunMeWhileTrue)
        {
            //Running while loop so we are sure user input correct data before returning.
            while (RunMeWhileTrue == true)
            {
                //clearing console
                Console.Clear();

                //print out nameString,  next line making user write in their name.
                Console.Write($"{nameString}");
                user.Name = Console.ReadLine();

                Console.Clear();
                //trying anything inside, if any error happens, it catch it and print out string error code.
                try
                {
                    Console.Write($"{ageString}");
                    user.Age = Convert.ToByte(Console.ReadLine());

                    //setting RunMeWhileTrue false to end the loop
                    RunMeWhileTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine(errorCode);
                    Console.ReadKey();
                }
            }

        }

        //Running method Rules, Require name and age to run.
        public void Rules(string Name, byte Age)
        {
            //Clearing Console
            Console.Clear();

            //Running if else statement checking age and then printing out text.
            if (Age < 3)
            {
                Console.WriteLine($"{Name}, {diaprtext}");
            }
            else if (Age >= 3 && Age <= 15)
            {
                Console.WriteLine($"{Name} {dadText}");
            }
            else if (Age >= 15 && Age <= 18)
            {
                Console.WriteLine($"{Name}, {momText}");
            }
            else if (Age >= 18 && Age <= 69)
            {
                Console.WriteLine($"{Name}, {allGrownText}");
            }
            else if (Age >= 70)
            {
                Console.WriteLine($"{Name}, {govermentLie}");
            }

        }


    }
}

