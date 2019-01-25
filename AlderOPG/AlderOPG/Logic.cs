using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderOPG
{
    //creating class logic to keep calculation
    class Logic
    {
        
        //Attribute
        //Creating bool True or false.
        bool runMeWhileTrue = true;

        //Properties

        //Creating get set bool.
        public bool RunMeWhileTrue
        {
            get { return runMeWhileTrue; }
            set
            {
                runMeWhileTrue = value;
            }
        }

        //Creating object of class Human
        public Human User = new Human("", 0);
    }
}
