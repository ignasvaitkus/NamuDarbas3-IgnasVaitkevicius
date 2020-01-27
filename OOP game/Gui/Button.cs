using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class Button : GuiObject
    {
        public bool IsActive { get;  set; } = false;

        public string Label {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }

        private string label =  "";

        private Frame notActiveFrame;
        private Frame activeFrame;

        private TextLine textLine;



        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
            
        }

        public override void Render()
        {
            if (IsActive)
            {
                activeFrame.Render();
            } else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }

        public void SetInActive()
        {
            IsActive = false;
        }

       

        public bool ActiveCheck()
        {
            return IsActive;
        }
    }
}
