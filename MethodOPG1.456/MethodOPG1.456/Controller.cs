using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPG1._456
{
    class Controller
    {
        //Creating objcet of class gui, to get access to all gui methods.
        Gui gui = new Gui();

        //Creating object of class logic, to get access to all method variables in logic.
        Logic logic = new Logic();

        //Creating Method for out program, throwing stuff from gui to logic and from logic to gui.
        public void PartOne()
        {
            //Open gui and reaching out for method called PrintCountingString.
            gui.PrintCountingString();


            //Setting a double UserInput, catching return value from user input from gui.
            double UserInput = gui.UserInputReturnX(logic.Number, logic.RunUntillDone);

            //setting logic.Number to the return value from gui
            logic.Number = UserInput;

            //Writing out result, required the UserInput and running calc method. 
            gui.TheResultGui(UserInput, logic.Calculate());
        }

    }
}
