using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._456
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object cmd 
            Controller Cmd = new Controller();
            //running method cmd.partone()
            Cmd.PartOne();
            //readkey so program doesnt quit on it self.
            Console.ReadKey();
        }
    }
}
