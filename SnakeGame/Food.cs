using System;
using System.Drawing;

namespace SnakeGame
{
    public class Food
    {
        int MapWidth;
        int MapHeight;
        private char[] Symbols = new[] {'Φ', 'Ω', '*'};
        private Color[] _colors = new[] {Color.Aqua, Color.Silver, Color.Green, Color.Navy, Color.Gold, Color.Salmon};
        
        Random rnd = new Random();

        public Food(int _mapWidth, int _mapHeight)
        {
            MapWidth = _mapWidth;
            MapHeight = _mapHeight;
            
        }

        public Point CaterFood()
        {
            int x = rnd.Next(2, MapWidth - 3);
            int y = rnd.Next(2, MapHeight - 3);
            return new Point(x, y, GetRandomSymbol(), GetRandomColor());
            
        }

        //Sümboli random
        private char GetRandomSymbol()
        {
            int random = rnd.Next(0, Symbols.Length - 1);
            return Symbols[random];
        }
        
        //Värvi random
        private Color GetRandomColor()
        {
            int random = rnd.Next(0, _colors.Length - 1);
            return _colors[random];
        }
    }
}