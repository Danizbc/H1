using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._456
{
    class Logic
    {
        //Attributes
        double number = 0;

        double result = 0;

        bool runUntillDone = false;


        //Properties
        public double Number
        {
            get { return number; }
            set
            {
                    number = value;
            }
        }

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
            }
        }

        public bool RunUntillDone
        {
            get { return runUntillDone; }
            set
            {
                runUntillDone = value;
            }
        }


        //methods
        public double Calculate()
        {
            return result = number + 32 - 297;
        }


    }
}
