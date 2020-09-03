using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class HorizontalLine:figure
    {
        

        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for(int x=xleft; x<= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }


           
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Drow();
           /* foreach(Point p in pList)
            {
                p.Drow();
            }*/
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
