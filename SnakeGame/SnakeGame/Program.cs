using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(30, 100);

            Point p = new Point(5, 5, '0');
            Snake snake = new Snake(10, Direction.DOWN, p);
            snake.Render();
            snake.Move();

            Console.ReadKey();

        }
    }
}
