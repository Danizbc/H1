using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOPG3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an random.
            Random Ran = new Random();

            //creating a array of ints with 0-99 index giving you 100 choices. 
            int[] numbers = new int[100];

            //looping through numbers.length and adding random numbers.
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = Ran.Next(1, 101);
                numbers[i] = temp;
                Console.WriteLine(numbers[i]);
            }

            //Sorting the list and printing out text, clearing console and such
            Console.WriteLine("Not sorted. \n\n Pess any key to sort array");
            Console.ReadKey();
            Console.Clear();
            //here is where it sort the list.
            Array.Sort(numbers);

            //Printing out every number in the array numbers. as you can see its now all sorted.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Array is now sorted, my OCD can be calm now.");
            Console.ReadKey();
        }
    }
}
