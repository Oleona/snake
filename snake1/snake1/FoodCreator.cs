using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake1
{
    class FoodCreator
    {
        int mapheight;
        int mapwidth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapwidth, int mapheight, char sym)
        {
            this.mapwidth = mapwidth;
            this.mapheight = mapheight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapwidth - 2);
            int y = random.Next(2, mapheight - 2);
            return new Point(x, y, sym);
        }

    }
}