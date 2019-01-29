using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._2
{
    class Logic
    {
        //Attribute the storing place for my variables
        double inputOne = 0;
        double inputTwo = 0;
        double result = 0;
        bool runWhileTrue = true;
        //Properties this is where i create get and set.
        public double InputOne
        {
            get { return inputOne; }
            set
            {
                inputOne = value;
            }
        }

        public double InputTwo
        {
            get { return inputTwo; }
            set
            {
                inputTwo = value;
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

        public bool RunWhileTrue
        {
            get { return runWhileTrue; }
            set
            {
                runWhileTrue = value;
            }
        }

        //method 
        public double Pythagoras()
        {
            result = (inputOne * inputOne + InputTwo * InputTwo);
            return result;
        }

        /// <summary>
        /// If true First input is bigger than secound input!
        /// </summary>
        /// <returns></returns>
        public bool BiggestNumber()
        {
            if (InputOne > InputTwo)
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
