using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {
        //Attributes
        double input = 0;
        double inputTwo = 0;
        double output = 0;
    
   

        //Properties
        public double Input
        {
            get { return input; }
            set
            {
            input = value;
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
        public double Output
        {
            get { return output; }
            set
            {
                output = value;
            }
        }

       public bool RunWhileTrue = true;



        //Methods

            //Devide and round up values.
        public double Devider()
        {
            Output = Input / InputTwo;
            output = Math.Round(output, 4);
            //returning value
            return output;
        }

        //Find Modus and round up to 4 digits.
        public double Modus()
        {
            output = Input % InputTwo;
            output = Math.Round(output, 4);
            //returning value
            return output;
        }

        //find potensenss and return value
        public double Potensenss()
        {
            // output = input ^ InputTwo;
           output = Math.Pow(input, InputTwo);
            //returning value
            return output;
        }

    }
}
