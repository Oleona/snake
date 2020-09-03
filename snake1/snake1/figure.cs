using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class figure
    {
        protected List<Point> pList;
        public virtual void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }

        internal bool IsMit(figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsMit(p))
                    return true;
            }
            return false;
        }

        public bool IsMit(Point point)
        {
foreach(var p in pList)
            {
                if (p.IsMit(point))
                    return true;
            }
            return false;
        }
    }
}
