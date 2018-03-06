using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(30, 100);

            Point p = new Point(5, 5, '0');
            Snake snake = new Snake(4, Direction.RIGHT, p);
            snake.Render();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadKey();

        }
    }
}
