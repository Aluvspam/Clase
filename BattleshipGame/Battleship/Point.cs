using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // this is first one '=='
        public static bool operator ==(Point obj1, Point obj2)
        {
            return (obj1.x == obj2.x && obj1.y == obj2.y);
        }

        // this is second one '!='
        public static bool operator !=(Point obj1, Point obj2)
        {
            return !(obj1.x == obj2.x && obj1.y == obj2.y);
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
