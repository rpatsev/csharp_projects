using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake : Line
    {
        public Direction direction; //TODO: the code never uses this variable outside this class, so better to make it private.

        //TODO: Use camelCase for local variables. 'length' intead of 'Length'.
        public Snake(int Length, Direction direction, Point tail)
        {
            //TODO: As snake moves starting from head, it's better to
            //call head a first point and tail a last point.
            pList = new List<Point>();
            for (int i = 0; i < Length; i++)
            {                
                Point p = new Point(tail);
                pList.Add(p);
                //TODO: Using 'point.Move' by 'i' is a very interesting solution, but not obvious.
                //Better to rerwrite in the manner that will be faster too read,
                //but I will leave it to your decision
                p.Move(i, direction);
                
            }
        }

        internal void Move()
        {
            //TODO: I would probably wrap 'pList' field and called it 'body' in the 'Snake' class.
            //'body.Remove(tail)' vs 'pList.Remove(tail)' looks more obvious.
            Point tail = pList.First();
            pList.Remove(tail);
            tail.Clear();

            Point head = MoveNext();
            pList.Add(head);          
            head.Render();
        }

        //TODO: it's better to separate the method below to 'CanEat' and 'Eat',
        //because at the moment it does two actions, which is not correct.
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

        //TODO: This method belongs to 'Snake' class only partly. This class 
        //shouldn't know how to handle user input, while direction changing is its the responsibility.
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
