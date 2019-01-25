using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg3
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //Danish Valuta
            double dkkValuta = 100;
            //Danish money.
            double dkk;
            
            //USD  valuta.
            double usdValuta = 658.88;
            //Used to convert USD to DKK.
            double usdToDkk;

            //GBP valuta
            double gbpValuta = 856.15;
            //Used to convert GBP to DKK.
            double gbpToDKK;
            
            //Euro Valuta
            double euroValuta = 746.67;
            //Used to convert Euro To DKK.
            double euroToDKK;

            //Swe Valuta
            double sekValuta = 72.88;
            //Used to convert SEK to DKK.
            double sekToDKK;
            
            //print out text
            Console.Write(" This machine will calculate DKK to USD, GBP, EURO, SEK. \n\n Write how many DKK u want to convert = ");
            
            //Make users able to input what number they want to be converted to other valuta.
            dkk = Convert.ToDouble(Console.ReadLine());

            //This Part calculate the valuta, by taking other valuta devide with danish valuta then devide that number with desire danish krones  we inputted
            usdToDkk = (dkk / (usdValuta / dkkValuta));
            gbpToDKK = (dkk / (gbpValuta / dkkValuta));
            euroToDKK = (dkk / (euroValuta / dkkValuta));
            sekToDKK = (dkk / (sekValuta / dkkValuta));
           

            //Print out all valuta. I making a $ beofore my text to allow me to write boxes inside my "" instead og using + + + everywhere.
            Console.WriteLine($"\n {dkk} Dkk = {Math.Round(usdToDkk, 2)} Dollar. \n\n" +
                $" {dkk} DKK = { Math.Round(gbpToDKK, 2)} Pund. \n\n" +
                $" {dkk} DKK = { Math.Round(euroToDKK, 2)} Euro. \n\n" +
                $" {dkk} DKK = {Math.Round(sekToDKK,2)} Sek. ");

            //And ofc a readkey so the program doesnt instantly shutdown.
            Console.ReadKey();





        }
    }
}
