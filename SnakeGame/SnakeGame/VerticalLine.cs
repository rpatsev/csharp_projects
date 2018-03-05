using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class VerticalLine : Line
    {
        public VerticalLine(int yUp, int yDown, int x, char mark)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, mark);
                pList.Add(p);
            }
        }

    }
}
