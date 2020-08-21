using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            //ramka
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();
            
            Point p = new Point(4,5, '+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
           /* Point p1 = new Point(1,3, '*');
            p1.Drow();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Drow();

            VerticalLine line1 = new VerticalLine(2, 7, 11, '*');
            line1.Drow();*/

            Console.ReadLine();
        }

        
    }
}
