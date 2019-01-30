using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG7
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object called cmd.
            Controller cmd = new Controller();

            //Running method in controller
            cmd.PartOne();

            Console.ReadKey();

        }
    }
}
