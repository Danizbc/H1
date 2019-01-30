using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG7
{
    class Gui
    {
        //Private method to print out string.
        private void PrintString(string txt)
        {
            Console.WriteLine(txt);
        }

        /// <summary>
        /// send text to printer, requirre int from array index 5
        /// </summary>
        /// <param name="Number"></param>
        public void FindIndexGui(int Number)
        {
            PrintString($"The number of index 5 = {Number}");
        }

        /// <summary>
        /// Send text to printer, requirre int number from result.
        /// </summary>
        /// <param name="Number"></param>
        public void PrintDoubleNumber(int Number)
        {
            PrintString($"The double result of index 5 = {Number}");
        }

    }
}
