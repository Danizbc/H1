using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Login User = new Login();

            //Propperties
            string[,] users = new string[2, 10];

            string username = "";

            string password = "";

            bool runUntillFalse = true;

            ConsoleKeyInfo input;




            //while loop so program end when we want it to.
            while (runUntillFalse == true)
            {
                //clearing console to make sure old text are removed.
                Console.Clear();

                Console.WriteLine("Welcome user. \n\nDo you have an account or do you want to create one? \n\nPress [C] to create account. \n\nPress [L] to login.");

                //making a readkey reading keyboard press.
                input = Console.ReadKey();

                //checking for C or  L, ( normaly i would use switch case, but in this case there only 2 options.
                if (char.ToLower(input.KeyChar) == 'c')
                {
                    //clearing old text again
                    Console.Clear();

                    //making user write user name and password
                    Console.Write("Write account name = ");
                    username = Console.ReadLine();

                    //making user write password from an method inside Login.cs
                    Console.Write("Write your password = ");
                    password = User.WritePassword(password);

                    //looping through user[0, i] to add accname and password .
                    for (int i = 0; i < users.GetLength(1); i++)
                    {
                        //if the index == null put user and password to that place. to make sure that we dont overwrite other people accounts.
                        if (users[0, i] == null && users[1, i] == null)
                        {
                            users[0, i] = username;

                            users[1, i] = password;

                            //to end the loop, so we dont create more than 1 account.
                            i = users.GetLength(1);

                            Console.Clear();
                            Console.WriteLine("Account Created. \nPress any key to continue.");
                        }
                    }

                    Console.ReadKey();

                }
                //making a login section
                else if (char.ToLower(input.KeyChar) == 'l')
                {
                    Console.Clear();

                    //inputing account name and password to save login information before checking in array users[,]
                    Console.Write("Write your account name & password. \nAccount Name = ");
                    username = Console.ReadLine();
                    Console.Write("Password = ");
                    User.WritePassword(password);

                    //running method from logic.cs (User) requirre username password, and the array, if it return through you logged in, else compiler made a mistake lolol, no name or pass are incorrect.
                    if (User.LoggingIn(username, password, users) == true)
                    {

                        runUntillFalse = false;
                    }
                    else
                    {
                        Console.WriteLine("\nWrong login login information.\nPress any key to try again.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong. Press any key to try again.");
                    Console.ReadKey();
                }

            }

            Console.Clear();
            Console.WriteLine($"Welcome {username} you logged in");
            Console.ReadKey();
        }



    }
}
