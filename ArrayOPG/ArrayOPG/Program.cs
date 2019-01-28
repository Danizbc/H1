using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating array
            int[] numbers = new int[10];
           
            //making for loop addding 0-9 into the array.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            //Running through the arary, if number[i] is equal 5 print out the number.
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
