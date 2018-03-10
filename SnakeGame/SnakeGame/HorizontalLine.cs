using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class HorizontalLine : Line
    {

        public HorizontalLine(int xLeft, int xRight, int y, char mark)
        {
            pList = new List<Point>(); //TODO: Here and in other classes: don't use shortenings and data type in names. 'points' instead of 'pList'.
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, mark);
                pList.Add(p);

            }
        }
    }
}
