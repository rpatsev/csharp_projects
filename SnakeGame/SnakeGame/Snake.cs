using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : Line
    {
        public Direction direction;

        public Snake(int Length, Direction direction, Point tail)
        {
            pList = new List<Point>();
            for (int i = 0; i < Length; i++)
            {
                Point p = new Point(tail);
                pList.Add(p);
                p.Move(i, direction);
                
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            tail.Clear();

            Point head = MoveNext();
            pList.Add(head);          
            head.Render();
        }

        internal bool Eat(Point food)
        {
            Point head = MoveNext();
            if (head.IsHit(food))
            {
                food.mark = head.mark;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        private Point MoveNext()
        {
            Point head = pList.Last();
            Point nextPoint = new SnakeGame.Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKeyPress(ConsoleKey key)
        {
                if (key == ConsoleKey.LeftArrow)
                    direction = Direction.LEFT;
                else if (key == ConsoleKey.RightArrow)
                    direction = Direction.RIGHT;
                else if (key == ConsoleKey.UpArrow)
                    direction = Direction.UP;
                else if (key == ConsoleKey.DownArrow)
                    direction = Direction.DOWN;
         
        }
    }
}
