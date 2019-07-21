using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        private Dictionary<Point, bool> map;

        private List<Ship> Fleet;

        public Player()
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 1);
            var minesweeper1 = new Ship(p1, p2);

            var p3 = new Point(7, 1);
            var p4 = new Point(7, 2);
            var minesweeper2 = new Ship(p3, p4);

            var p5 = new Point(4, 5);
            var p6 = new Point(6, 5);
            var battleship = new Ship(p5, p6);

            var p7 = new Point(9, 5);
            var p8 = new Point(9, 8);
            var destroyer = new Ship(p7, p8);

            Fleet = new List<Ship>() { minesweeper1, minesweeper2, battleship, destroyer };

            //map = new Dictionary<Point, bool>();

            //foreach (var ship in Fleet)
            //{
            //    if(ship.Start.x == ship.Finish.x)
            //    {
            //        for (int i = ship.Start.y; i <= ship.Finish.y; i++)
            //        {
            //            map.Add(new Point(ship.Start.x, i), true);
            //        }
            //    }

            //    if (ship.Start.y == ship.Finish.y)
            //    {
            //        for (int i = ship.Start.x; i <= ship.Finish.x; i++)
            //        {
            //            map.Add(new Point(i, ship.Start.y), true);
            //        }
            //    }
            //}                    
        }

        public string Attack(Point attack)
        {
            string result = null;
            bool hit = false;
            foreach (var ship in Fleet)
            {
                foreach (var space in ship.Spaces)
                {
                    if (attack == space.Key && space.Value)
                    {
                        hit = true;
                        ship.Spaces[space.Key] = false;
                        if (ship.Alive)
                        {
                            result = "hit";
                            break;
                        }
                        else
                        {
                            if (FleetAlive())
                            {
                                result = "sink";
                                break;
                            }
                            else
                            {
                                result = "surrender";
                                break;
                            }
                        }
                    }
                }
            }
            if (!hit)
            {
                result = "miss";
            }
            return result;
        }

        private bool FleetAlive()
        {
            foreach (var ship in Fleet)
            {
                if (ship.Alive)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
