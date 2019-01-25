using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderOPG
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating class Controller
            Controller ctrl = new Controller();

            //Open Controller and run method StartProgram.
            ctrl.StartProgram();
            
            //Readkey so program doesnt shut down after running
            Console.ReadKey();

            

        }
    }
}
