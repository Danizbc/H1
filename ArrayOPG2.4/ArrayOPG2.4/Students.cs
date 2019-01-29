using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG2._4
{
    class Students
    {
        //Attributes

        float grade = 0;

        string name = "";

        string lastName = "";

        List<string> listOfNames = new List<string>() { "Anders", "Sofie", "Alias", "bent", "Benny", "Charlotte", "Bubber", "Casper", "Daniella", "Danny", "Sofie", "Sandra", "Peter", "Thomas", "Sara", "Karla", "René", "Lotte", "Rene", "Yvonne" };

        List<string> listOfLastNames = new List<string>() { "Andersen", "Sørensen", "Hansen", "Kristensen", "Lang", "Jensen", "Petersen", "Cornelius", "Nielsen", "Benneweis" };

        //Properties

        //making my get, set.
        public float Grade
        {
            get { return grade; }
            set
            {
                grade = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public List<string> ListOfNames
        {
            get { return listOfNames; }
            set
            {
                listOfNames = value;
            }
        }

        public List<string> ListOfLastNames
        {
            get { return listOfLastNames; }
            set
            {
                listOfLastNames = value;
            }
        }

        public static Random Ran = new Random();

        //Constructor to create object student.
        public Students(int ID)
        {
            /* switch case, requirre id from constructor, depends on id it get in it will create 1 or 2. if i want some case 1 to have other names i could make another list for them
             * Like case 0 = malesnames & case 1 = female names;  i havent randomize with difference, but i leave it be for now if i need to use it in the future.
             */

            switch (ID)
            {
                case 0:
                    int temp = ListOfNames.Count - 1;
                    Name = ListOfNames[Ran.Next(0, temp)];

                    int temp2 = ListOfLastNames.Count - 1;
                    LastName = ListOfLastNames[Ran.Next(0, temp2)];

                    break;

                case 1:

                    int temp3 = ListOfNames.Count - 1;
                    Name = ListOfNames[Ran.Next(0, temp3)];

                    int temp4 = ListOfLastNames.Count - 1;
                    LastName = ListOfLastNames[Ran.Next(0, temp4)];

                    break;

            }
        }

    }
}
