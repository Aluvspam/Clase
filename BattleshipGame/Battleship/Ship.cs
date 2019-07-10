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
        public int Spaces;

        public Ship(Point Start, Point Finish)
        {
            this.Start = Start;
            this.Finish = Finish;
            if (Start.x == Finish.x)
            {
                Spaces = Math.Abs(Start.y - Finish.y);
            }

            if (Start.y == Finish.y)
            {
                Spaces = Math.Abs(Start.x - Finish.x);
            }
        }
    }
}
