using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        public Point Start;
        public Point Finish;
        public Dictionary<Point, bool> Spaces;

        public Ship(Point Start, Point Finish)
        {

            this.Start = Start;
            this.Finish = Finish;
            Spaces = new Dictionary<Point, bool>();
            if (Start.x == Finish.x)
            {
                for(int i = Start.y; i <= Finish.y; i++)
                {
                    Spaces.Add(new Point(Start.x, i), true);
                }
            }

            if (Start.y == Finish.y)
            {
                for (int i = Start.x; i <= Finish.x; i++)
                {
                    Spaces.Add(new Point(i, Start.y), true);
                }
            }
        }
    }
}
