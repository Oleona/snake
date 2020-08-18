using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x,int ydown, int yup,  char sym)
        {
            pList = new List<Point>();
            for (int y = ydown; y <= yup; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
                p.Drow();
        }
    }
}

