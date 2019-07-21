using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Point
    {
        public int row;
        public int column;

        public Point(int x, int y)
        {
            this.row = x;
            this.column = y;
        }
        // this is first one '=='
        public static bool operator ==(Point obj1, Point obj2)
        {
            return (obj1.row == obj2.row && obj1.column == obj2.column);
        }

        // this is second one '!='
        public static bool operator !=(Point obj1, Point obj2)
        {
            return !(obj1.row == obj2.row && obj1.column == obj2.column);
        }

        public override string ToString()
        {
            return "(" + row + ", " + column + ")";
        }
    }
}
