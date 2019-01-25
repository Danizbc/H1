using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderOPG
{
    class Controller
    {
        //creating access to class Logic.
        Logic logic = new Logic();

        //creating access to class Gui.
        Gui gui = new Gui();

        public void StartProgram()
        {
            //Open class Gui, running method NameAndAge, Method require an user and bool to run, getting it from logic. 
            gui.NameAndAge(logic.User, logic.RunMeWhileTrue);

            //Open Class gui to run Method Rules that requirre an string name and byte age, by open logic we can access objcet user that contain variable name.
            gui.Rules(logic.User.Name, logic.User.Age);
        }
       
        
    }
}
