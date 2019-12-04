using System;
using System.Drawing;
using System.Linq;

namespace SnakeGame
{
    public class Snake:Figure
    {
        public Point head;
        public Point tail;
        public Direction Direction;

        public Snake(int length, Direction _direction)
        {
            //ussi alguspunkt ja kuju
            tail= new Point(6,5,'■', Color.Navy);
            Direction = _direction;
            for (int i = 0; i < length; i++)
            {
                Point newPoint =new Point(tail);
                newPoint.MovePoint(i,Direction);
                pointList.Add(newPoint);
            }
            
        }

        public void MoveSnake()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();
        }
        
        //Punkt mis näitab kuhu järgmisena ussi pea läheb
        public Point GetNextPoint()
        {
            head = pointList.Last();
            Point nextPoint= new Point(head);
            nextPoint.MovePoint(1, Direction);
            return nextPoint;

        }

        public void ReadUserKey(ConsoleKey key)
        {
            if (key==ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
        }
        
        public bool Eat(Point food)
        {
            head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pointList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    
}