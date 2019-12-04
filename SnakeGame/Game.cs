using System;
using System.Drawing;
using System.Threading;
using Console = Colorful.Console;

namespace SnakeGame
{
    public class Game
    {
        private Wall walls;
        private ConsoleKey currentKey = ConsoleKey.RightArrow;
        //Skoori lugemise jaoks
        private int Count =0;
        

        public Game()
        {
            Console.CursorVisible = false;

            walls = new Wall(70,20);
            

            Snake snake= new Snake(4, Direction.RIGHT);
            Food foodCatered = new Food(70, 20);
            Point food = foodCatered.CaterFood();
            
            
            
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                walls.DrawWalls();
                snake.DrawFigure();
                food.Draw();
                DrawScore(Count);
                
                if (snake.Eat(food))
                {
                    food = foodCatered.CaterFood();
                    food.Draw();
                    Count++;
                }
                //Uss saab surma kui sõidav vastu ennast või seina
                else if (walls.IsHitByFigure(snake) || snake.IsHitByPoint(snake.head))
                {
                    break;
                }
                else
                {
                    snake.MoveSnake();
                }
                
                Thread.Sleep(GetTimeout());
                if (Console.KeyAvailable)
                {
                    currentKey = Console.ReadKey(true).Key;
                    if (currentKey == ConsoleKey.P)
                    {
                        Console.WriteLine("Game is on pause!");
                        Console.ReadKey(true);
                    }
                    snake.ReadUserKey(currentKey);
                }
            }
            GameOver(Count);
        }

        //uss läheb kiiremaks, kui on kokku saanud teatud arv punkte
        public int GetTimeout()
        {
            if (Count< 6)
            {
                return 200;
            }
            else if (Count <9)
            {
                return 180;
            }
            else if (Count <11)
            {
                return 160;
            }
            else if(Count <9)
            {
                return 140;
            }
            else if (Count <10)
            {
                return 120;
            }
            else if (Count <11)
            {
                return 90;
            }

            return 70;

        }

        //Skoori lugemine mängu sees
        public static void DrawScore(int score)
        {
            ShowMessage($" Points: {score} ", 0,0,Color.Navy);
        }
        
        public static void GameOver(int count)
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.SetCursorPosition(xOffset,yOffset++);
            ShowMessage("_________", xOffset,yOffset++, Color.Red);
            ShowMessage("GAME OVER", xOffset, yOffset++, Color.Red);
            ShowMessage("_________", xOffset,yOffset++, Color.Red);
            ShowMessage($"Score: {count}", xOffset,yOffset,Color.Orange);
            ShowMessage("Press any key to continue", xOffset -7,yOffset +4,Color.Orange);
            Console.ReadKey();
        }
        public static void ShowMessage(string text, int xOffset, int yOffset, Color color)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.Write(text, color);
        }
    }
}