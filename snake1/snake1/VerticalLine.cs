﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class VerticalLine: figure
    {
        
        public VerticalLine(int yup,int ydown,int x, char sym)
        {
            pList = new List<Point>();
            for (int y =yup ; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }

        
    }
}

