using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    //TODO: The snake doesn't crash when hits the wall.
    //TODO: After the food is eaten, new food doesn't appear.
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: All the fields and actions below should belong to the class 'Game'.
            int fieldHeight = 30;
            int fieldWidth = 100;

            Field field = new Field(fieldHeight, fieldWidth);

            //TODO: Don't use 'magic numbers'. All literals should be somehow called when passed to the methods.
            Point p = new Point(6, 9, '0');
            Snake snake = new Snake(4, Direction.RIGHT, p);//TODO: Better to call 'point' a 'tail' here.
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
