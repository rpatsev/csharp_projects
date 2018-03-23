using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    //TODO: Consider using struct instead of class
    public class Point
    {

        public int x;
        public int y;
        public char mark;

        //TODO: Don't leave unused code. The constructor below has 0 references.
        public Point()
        {
            
        }

        public Point(int x, int y, char mark)
        {
            this.x = x;
            this.y = y;
            this.mark = mark;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            mark = p.mark;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.RIGHT:
                    x = x + offset;
                    break;

            }
        }

        //TODO: From the code below, it's rather 'Equals' than 'IsHit'. Override 'Equals' method of 'object' class.
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear()
        {
            //TODO: Using this implementation of 'Clear', how would you 'Render' a point after 'Clear' it?
            mark =  ' ';
            Render();
        }

        public void Render()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(mark);            
        }
    }
}
