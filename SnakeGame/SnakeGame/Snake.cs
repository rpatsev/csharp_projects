using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : Line
    {
        Direction direction;

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
            pList.Remove(tail);
            Point head = MoveNext();
            pList.Add(head);

            tail.Clear();
            head.Render();
        }


        private Point MoveNext()
        {
            Point head = pList.Last();
            Point nextPoint = new SnakeGame.Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
