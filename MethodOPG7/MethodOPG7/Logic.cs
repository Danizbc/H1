using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG7
{
    class Logic
    {
        //Attributes
        int[] numbersArray = new int[9];
        int result = 0;

        //Properties
        public int[] NumbersArray
        {
            get { return numbersArray; }
            set
            {
                numbersArray = value;
            }
        }

        public int Result
        {
            get { return result; }
            set
            {
                result = value;
            }
        }

        //Methods

            /// <summary>
            /// This method loops the lengt of the array and add 1-9 to the array.
            /// </summary>
        public void AddToArray()
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = i;
            }
        }

        /// <summary>
        /// Loops through the array and find value of index 5
        /// </summary>
        public void FindNumber()
        {
            for (int i = 0; i < NumbersArray.Length; i++)
            {
                if (i == 5)
                {
                    Result = NumbersArray[i];
                }
            }
        }

        /// <summary>
        /// Takes index 5 and multiply with 2, to double up the value.
        /// </summary>
        /// <returns></returns>
        public int DoubleUpNumber()
        {
            NumbersArray[5] *= 2;
            result = numbersArray[5];
            return result;
        }

    }
}
