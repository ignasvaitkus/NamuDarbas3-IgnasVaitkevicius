using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
     class GameWindow : Window
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        Button button = new Button(0, 0, 120, 30, "");
        CreditWindow creditWindow = new CreditWindow();
        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> {"SpaceWar Game", "Igno Vaitkeviciaus kuryba!", "Made in Vilnius Coding School!"});

            startButton = new Button(20, 13, 18, 5, "Start");
            

            creditsButton = new Button(50, 13, 18, 5, "Credits");

            quitButton = new Button(80, 13, 18, 5, "Quit");

        }

        public bool RenderGameWindow()
        {
            startButton.SetActive();
            creditsButton.SetInActive();
            quitButton.SetInActive();
            int x = 0;

            while (x != 1)
            {
                base.Render();
                titleTextBlock.Render();

                startButton.Render();
                creditsButton.Render();
                quitButton.Render();

                Console.SetCursorPosition(0, 0);



                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            x = 1;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear(); return false;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        {
                            if (startButton.ActiveCheck())
                            {
                                startButton.SetInActive();
                                creditsButton.SetActive(); break;
                            }
                            if (creditsButton.ActiveCheck())
                            {
                                creditsButton.SetInActive();
                                quitButton.SetActive(); break;
                            }

                            if (quitButton.ActiveCheck())
                            {
                                quitButton.SetInActive();
                                startButton.SetActive(); break;
                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        {
                            if (startButton.ActiveCheck())
                            {
                                startButton.SetInActive();
                                quitButton.SetActive(); break;
                            }
                            if (creditsButton.ActiveCheck())
                            {
                                creditsButton.SetInActive();
                                startButton.SetActive(); break;
                            }

                            if (quitButton.ActiveCheck())
                            {
                                quitButton.SetInActive();
                                creditsButton.SetActive(); break;
                            }
                        }
                        break;

                }

                if(x==1)
                {
                    if(creditsButton.ActiveCheck())
                    {
                        x = 0;
                        Console.Clear();
                        creditWindow.Render();
                    }

                    if (quitButton.ActiveCheck())
                    {
                        Console.Clear();
                        return false;
                    }
                }

            } 
            Console.Clear();
            return true;
            
        }
    }
}
