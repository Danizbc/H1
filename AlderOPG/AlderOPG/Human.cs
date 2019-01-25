using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderOPG
{
    /// <summary>
    /// Creating Human Class
    /// </summary>
    class Human
    {
        //Attributes
        private string name = "";

        private byte age = 0;

       


        //Properties
        //Creating properties with get set.
        internal string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        internal byte Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

     


        /// <summary>
        /// This is a constructor.
        /// Create Human with Name and Age, Require 2x String before you can use this constructor!
        /// </summary>
        /// <param name="ErrorString"></param>
        /// <param name="NameAndAgeStribng"></param>
        public Human(string InputName, byte InputAge)
        {
            //Name and age is added by InputName, To create this it require string and byte.
            name = InputName;

            age = InputAge;
            
        }

    }




}

