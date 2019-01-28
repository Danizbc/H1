using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG2
{
    class Login
    {
        //Making an method to covert password into * instead of showing password in console.
        public string WritePassword(string password)
        {
            //Making bool to run untill false;
            bool running = true;
          
            //creating do while, to make sure user get his password before exiting program.
            do
            {
                //making
                ConsoleKeyInfo key = Console.ReadKey(true);
           
                //coverting key press to string, then printing out * for each key press
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                // Making able to delete password, without taking key and backspace as a key to password. (\b = backspace)
                else
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        running = false;
                    }
                }
            } while (running == true);


            //Returning password to where password method is running.
            return password;
        }


        //creating bool that return true or falls depend on login information is correct. requirre 2 string and a string array.
        public bool LoggingIn(string UserName, string Password, string[,] Users)
        {
            //Bool name and password, if both are correct return the method as true
            bool nap = false;
            
            //looping through users[0,i] for username and [i,0] for password if it match it log you in.
            for (int i = 0; i < Users.GetLength(1); i++)
            {
                if (Users[0,i] == UserName && Users[1,i] == Password)
                {
                    nap = true;
                    //setting i to the lengt of users to stop running through any more users.
                    i = Users.GetLength(1);
                }
            }

            //if name and password is true return LogginIn bool method as true or false.
            if (nap == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
