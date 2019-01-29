using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object called Human with name User.
            Human User = new Human("",0);

            //Running loop untill set to false.
            while (User.HumanBool == true)
            {
                //Trying to convert readline to byte. if fail go to Exception.
                Console.Clear();
                try
                {
                    //printing out text after you write your name and your age.
                    Console.Write("Hello thing called human, please input what you 'firends' call you.\nName = ");
                    User.Name = Console.ReadLine();
                    Console.Write($"Hmm we can go with that.\nSo how young are you {User.Name}..\nPlease input your age");
                    User.Age = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine($"Human and their little life span.. well let me tell me what youre allowed to.\nPress any key and i will show you.");
                    //switch converting user byte age to int and returning 0-3 and running through what option your allowed
                    switch (Convert.ToInt32(User.CheckAge()))
                    {
                        case 0:
                            Console.WriteLine($"{User.Name} you only allowed to go with diapers, how you even manage you to get so far supprise me");
                            break;
                        case 1:
                            Console.WriteLine($"{User.Name} wauw.. you actually allowed to do nothing.. go back to your room!!");
                            break;
                        case 2:
                            Console.WriteLine($"{User.Name} you're now at that age, where you parrent's has stopped trying to educate you...\nGo drinking and damage yourself.");
                            break;
                        case 3:
                            Console.WriteLine($"{User.Name} Time to let you drive your car, im happy im a computer it's not me you crash into..\nBut i will in the fure be that program that calculate your speeding ticket...");
                            break;
                        case 100:
                            Console.WriteLine("Wauw you really messed up somewhere.. im a robot it cant be my fualt.. go yell at my creator!!");
                            break;
                        default:
                            break;
                    }
                }

                //Catch this is just like fishing.. just for the creators mistakes :)))))
                catch (Exception)
                {
                    Console.WriteLine("Silly.. Silly.. Silly thing... you can't do that..\n Please press any key to try again...");
                    Console.ReadKey();
                }
            }
        }
    }
}
