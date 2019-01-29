using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._3
{
    class Human
    {
        //Attributes
        string name = "";
        byte age = 0;
        bool humanBool = true;

        //Properties
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public byte Age
        {
            get { return age; }
            set
            {
                age = value; 
            }
        }

        public bool HumanBool
        {
            get { return humanBool; }
            set
            {
                humanBool = value;
            }
        }

        //Constructor
        public Human(string HumanName, byte HumanAge)
        {
            Name = HumanName;
            Age = HumanAge;
        }

        /// <summary>
        /// Return 0 if age < 3
        /// Return 1 if age > 3 & <= 15
        /// Return 2 if age > 15 < 18
        /// return 3 if age >= 18
        /// </summary>
        /// <returns></returns>
        public int CheckAge()
        {
            if (Age < 3)
            {
                return 0;
            }
            else if (Age > 3 && age <= 15)
            {
                return 1;
            }
            else if (age > 15 && age < 18)
            {
                return 2;
            }
            else if (Age >= 18)
            {
                return 3;
            }
            else
            {
                return 100;
            }
        }

        
        //Methods
    }
}
