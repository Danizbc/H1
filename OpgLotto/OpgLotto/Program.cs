using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //making random 
            Random ran = new Random();
            //Craeint array of ints with 7 reserved index.
            int[] lottoNumbers = new int[7];
            int[] lottoCoupon = new int[7];
            int counting = 0;

            //Running for loop adding random numbers.
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                lottoNumbers[i] = ran.Next(1, 21);
                lottoCoupon[i] = ran.Next(1, 21);
            }
            //sorting both arrays.
            Array.Sort(lottoCoupon);
            Array.Sort(lottoNumbers);

            //Writing out user lotto coupon numbers
            Console.WriteLine("your lotto coupon numbers are");
            for (int i = 0; i < lottoCoupon.Length; i++)
            {
                Console.Write(lottoCoupon[i] + " ");
            }
            //Writing out Lotto Numbers
            Console.WriteLine("\nThe lotto numbers are");
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                Console.Write(lottoNumbers[i] + " ");
            }
            //checking if user have any match 
            for (int j = 0; j < lottoCoupon.Length; j++)
            {
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    if (lottoNumbers[j] == lottoCoupon[i])
                    {
                        counting++;

                    }
                } 
            }
           
            //Printing out user winnings, by a switch case.
            switch (counting)
            {
                
                case 2:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 1.000 DKK!!");
                    break;
                case 3:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 2.000 DKK");
                    break;
                case 4:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 12.500 DKK");
                    break;
                case 5:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 30.000 DKK");
                    break;
                case 6:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 1 MILION DKK");
                    break;
                case 7:
                    Console.WriteLine($"\nyou got {counting} right.\n\n you won 999999 MILIARDER DKK");
                    break;

                default:
                    Console.WriteLine("\nAWW you didnt win");
                    break;
            }
            Console.ReadKey();

        }
    }
}
