using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : Line
    {
        

        public Snake(int Length, Direction direction, Point tail)
        {
            pList = new List<Point>();
            for (int i = 0; i < Length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            //pList
        }
    }
}
