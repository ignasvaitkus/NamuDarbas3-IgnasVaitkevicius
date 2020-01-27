using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class ExitWindow:Window
    {
        private Button exitButton;
        public ExitWindow() : base(0, 0, 120, 30, '%')
        {
            exitButton = new Button(46, 13, 28, 5, "Thank you for playing!");
        }

        public override void Render()
        {
            base.Render();
            exitButton.Render();
            

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
