using System.Collections.Generic;

namespace SnakeGame
{
    public class Wall
    {
        private List<Figure> _wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            _wallList = new List<Figure>();
            
            Line topLine = new Line();
            topLine.CreateHorizontal(0,mapWidth -2,0,'═');
            Line bottomLine = new Line();
            bottomLine.CreateHorizontal(0,mapWidth -2,mapHeight -1, '═');
            Line leftLine = new Line();
            leftLine.CreateVertical(0,mapHeight -1, 0, '║');
            Line rightLine = new Line();
            rightLine.CreateVertical(0, mapHeight -1, mapWidth -2, '║');
            
            _wallList.Add(topLine);
            _wallList.Add(bottomLine);
            _wallList.Add(leftLine);
            _wallList.Add(rightLine);
        }

        public void DrawWalls()
        {
            foreach (Figure wall in _wallList)
            {
                wall.DrawFigure();
            }
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach (Figure wall in _wallList)
            {
                if (wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }

            return false;
        }
    }
}