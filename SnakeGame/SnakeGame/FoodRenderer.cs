using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class FoodRenderer
    {
        int fieldHeight;
        int fieldWidth;
        char foodMark;

        char[] foodMenu = { '&' , '*' , '/', '#'}; //TODO: Looks good, but the requirement was to implement different food 
                                                   //using polimorphism principle implementation in C#.
        Random rand = new Random();

        public FoodRenderer(int height, int width)
        {
            this.fieldHeight = height;
            this.fieldWidth = width;
        }

        public Point RenderFood()
        {
            int x = rand.Next(2, fieldWidth - 2);
            int y = rand.Next(2, fieldHeight - 2);
            foodMark = foodMenu[rand.Next(0,foodMenu.Length)];
            return new SnakeGame.Point(x, y, foodMark); 
        }
    }
}
