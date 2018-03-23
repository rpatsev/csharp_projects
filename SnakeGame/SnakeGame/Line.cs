//TODO: Here and in other classes - remove unused usings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    //TODO: What if someone creates 'Line' object and calls 'Render'?
    public class Line
    {
        protected List<Point> pList;

        public void Render()
        {
            foreach (Point p in pList)
            {
                p.Render();
            }
        }
    }
}
