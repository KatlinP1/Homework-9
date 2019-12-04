using System.Drawing;

namespace SnakeGame
{
    public class Line:Figure
    {
        public void CreateVertical (int yTop, int yBottom, int x, char symbol)
        {
            for (int i = yTop; i<= yBottom; i++)
            {
                Point newPoint= new Point(x,i, symbol, Color.Orange);
                pointList.Add(newPoint);
            }
        }
        
        public void CreateHorizontal(int xLeft, int xRight, int y, char symbol)
        {
            for (int i = xLeft; i < xRight; i++)
            {
                Point newPoint=new Point(i, y, symbol,Color.Orange);
                pointList.Add(newPoint);
            }
        }
    }
}