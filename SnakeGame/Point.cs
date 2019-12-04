using System;
using System.Drawing;
using Console = Colorful.Console;

namespace SnakeGame
{
    public class Point
    {
        public int x;
        public int y;
        public char symbol;
        public Color _color;
        
        public Point(int _x, int _y, char _symbol, Color color)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
            _color = color;
            
        }

        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
            _color = _p._color;
        }
        
        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(symbol, _color);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void MovePoint(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction== Direction.DOWN)
            {
                y = y + offset;
            }
            
        }

        public bool IsHit(Point point)
        {
            return point.x == x && point.y == y;
        }

    }
}