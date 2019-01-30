using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG7
{
    class Controller
    {
        private Logic logic = new Logic();
        private Gui gui = new Gui();

        /// <summary>
        /// used to run methods, throwing data from gui to logic and other way around. 
        /// </summary>
        public void PartOne()
        {
            logic.AddToArray();

            logic.FindNumber();

            gui.FindIndexGui(logic.Result);

            logic.DoubleUpNumber();

            gui.PrintDoubleNumber(logic.Result);
        }

    }
}
