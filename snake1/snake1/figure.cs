﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class figure
    {
        protected List<Point> pList;
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }
    }
}
