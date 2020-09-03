using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace snake1
{
     class Walls
    {
        List<figure> wallList;

        public Walls(int mapwidth, int mapheight)
        {
            wallList = new List <figure>();

            //ramka
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsMit(figure figure)
        {
foreach (var wall in wallList)
            {
                if(wall.IsMit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}