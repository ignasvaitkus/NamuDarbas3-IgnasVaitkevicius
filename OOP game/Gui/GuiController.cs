using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    sealed class GuiController:GameWindow
    {

        public GuiController()
        {
            GameWindow gameWindow = new GameWindow();
            CreditWindow creditWindow = new CreditWindow();
        }

        public bool ShowMenu()
        {
            if (base.RenderGameWindow()) return true;
            else return false;
                
           
        }

    }
}
