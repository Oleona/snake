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
            //Console.WriteLine("Hello, World!");
            // int x1 = 1;
            // int y1 = 3;
            // char sym1 = '*';
            // Console.SetCursorPosition(x1, y1);
            // Console.Write(sym1);
            // Drow(x1, y1, sym1);
            //Point p1 = new Point();
            Point p1 = new Point(1,3, '*');
            /* p1.x = 1;
             p1.y = 3;
             p1.sym = '*';*/
            //Drow(p1.x, p1.y, p1.sym);
            p1.Drow();

            
            Point p2 = new Point(4,5, '#');
            p2.Drow();

            Console.ReadLine();
        }

        /*static void Drow(int x, int y, char sym)
        {
 Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
    }
}
