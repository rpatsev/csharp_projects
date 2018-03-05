using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Field
    {
        public Field(int height, int width)
        {
            Console.SetWindowSize(width, height);


            HorizontalLine top = new HorizontalLine(0, width-1, 0, '-');
            HorizontalLine bottom = new HorizontalLine(0, width - 1, height-1, '-');
            VerticalLine left = new VerticalLine(1, height - 1, 0, '|');
            VerticalLine right = new VerticalLine(1, height - 1, width - 1, '|');

            left.Render();
            right.Render();
            top.Render();
            bottom.Render();
        }
    }
}
