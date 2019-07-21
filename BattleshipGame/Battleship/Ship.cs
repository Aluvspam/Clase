﻿using System;
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
            if (Start.row == Finish.row)
            {
                for(int i = Start.column; i <= Finish.column; i++)
                {
                    Spaces.Add(new Point(Start.row, i), true);
                }
            }

            if (Start.column == Finish.column)
            {
                for (int i = Start.row; i <= Finish.row; i++)
                {
                    Spaces.Add(new Point(i, Start.column), true);
                }
            }
        }
    }
}
