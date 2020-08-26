using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Snake: figure
    {
        Direction direction;
        public Snake(Point tail,int lenght,Direction _direction)
            {
            direction = _direction;
            pList = new List<Point>();
            for(int i=0; i< lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
    }
}
