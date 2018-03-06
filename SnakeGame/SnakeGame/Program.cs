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
            int fieldHeight = 30;
            int fieldWidth = 100;

            Field field = new Field(fieldHeight, fieldWidth);

            Point p = new Point(6, 9, '0');
            Snake snake = new Snake(4, Direction.RIGHT, p);
            snake.Render();

            FoodRenderer foodRenderer = new FoodRenderer(fieldHeight, fieldWidth);
            Point food = foodRenderer.RenderFood();
            food.Render();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodRenderer.RenderFood();
                    food.Render();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeyPress(key.Key);
                }
                Thread.Sleep(250);
                snake.Move();
            }
        }
    }
}
