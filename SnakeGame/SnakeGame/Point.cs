using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Point
    {

        public int x;
        public int y;
        public char mark;

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

        public void Clear()
        {
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
