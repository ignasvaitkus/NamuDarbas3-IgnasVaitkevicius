using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Game;
using ConsoleGame.Gui;

namespace ConsoleGame
{
    class Program
    {
        static void Main()
        {

             Console.CursorVisible = false;

            GuiController guiController = new GuiController();
            GameController myGame = new GameController();
            do
            {
                if (guiController.ShowMenu())
                    myGame.StartGame();
                else break;
            }
            while (guiController.ShowMenu() == true);

            ExitWindow exitWindow = new ExitWindow();
            exitWindow.Render();
            // GameWindow gameWindow = new GameWindow();
            // gameWindow.Render();
            ///CreditWindow creditWindow = new CreditWindow();
           // creditWindow.Render();
            



             
        }
    }
}
