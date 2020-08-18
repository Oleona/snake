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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);

            List<char> charList = new List<char>();
            charList.Add('^');
            List<char> charList1 = new List<char> { '&', '$', '*', '!', '@' };
            charList.AddRange( charList1);
            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }

            Point p3 = new Point(7, 9, '!');
            p3.Drow();

            Point p4 = new Point(14, 7, '@');
            p4.Drow();

            Point p5 = new Point(9, 11, '$');
            p5.Drow();

            Point p6 = new Point(1, 14, '(');
            p6.Drow();

            plist.Add(p3);
            plist.Add(p4);
            plist.Add(p5);
            plist.Add(p6);
Console.WriteLine();
            foreach (Point p in plist)
            {
                
                Console.Write("{0} {1}: {2}", p.x, p.y, p.sym);
                
                Console.WriteLine();

                string output = String.Format("x: {0}  y: {1} : sym :{2}", p.x, p.y, p.sym);
                Console.WriteLine(output);


            }

            Console.ReadLine();
        }

        /*static void Drow(int x, int y, char sym)
        {
 Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
    }
}
