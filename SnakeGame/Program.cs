using System;
using System.Drawing;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string cmd = "";
                
            while (cmd?.ToLower() != "x")
            {
                Console.Clear();
                int xOffset = 23;
                int yOffset = 3;
                
                PrintSnake();
                Game.ShowMessage("SNAKE GAME", xOffset,yOffset++, Color.Navy);
                Game.ShowMessage("Type a to play", xOffset,yOffset++, Color.Navy);
                Game.ShowMessage("Type x to exit ", xOffset,yOffset++, Color.Navy);
                Game.ShowMessage("Tutorial: ", xOffset-7,yOffset+4, Color.Orange);
                Game.ShowMessage("1. Use arrows to move the snake.", xOffset-7,yOffset+5, Color.Orange);
                Game.ShowMessage("2. Type p to pause the game while playing.", xOffset-7,yOffset+6, Color.Orange);
                Game.ShowMessage("> ", xOffset,yOffset++, Color.Navy);
                

                cmd = Console.ReadLine();
                if (cmd?.ToLower() =="x")
                {
                    break;
                }


                var game = new Game();
            }
            Console.ReadLine();
        }

        public static void PrintSnake()
        {
            Console.WriteLine("      __");
            Console.WriteLine("     {0O}");
            Console.WriteLine("     \\__/");
            Console.WriteLine("      /^/");
            Console.WriteLine("     ( (      ");
            Console.WriteLine("     \\_\\___");
            Console.WriteLine("     (_______)");
            Console.WriteLine("    (_________()Oo");
            
            //Snake pilt võetud https://ascii.co.uk/art/snake
        }
    }
}