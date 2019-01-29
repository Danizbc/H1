using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeB = new List<int>();
            List<int> listeC = new List<int>();

            int i, num = 21;

            //running for loop adding all even numbers that doesnt add up to 3
            for (i = 0; i < num; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    listeB.Add(i);
                    Console.WriteLine(i);
                }

            }
            //7 elements in the list.
            Console.Clear();
            //removing 17 and storing index 3 in atemp before overwrite it with 17, then adding temp again.
            listeB.Remove(17);
            int temp = listeB[3];
            listeB[3] = 17;
            listeB.Add(temp);
            //foreach (int item in listeB)
            //{
            //    Console.WriteLine(item);
            //}

            listeC = listeB;
            listeC.Reverse();

            foreach (int item in listeC)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

    






        }





















    }
}





