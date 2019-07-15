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
            var p1 = new Point(1, 1);
            var p2 = new Point(1, 2);
            var minesweeper1 = new Ship(p1,p2);

            p1.x = 7;
            p1.y = 1;
            p2.x = 7;
            p2.y = 2;
            var minesweeper2 = new Ship(p1, p2);

            p1.x = 4;
            p1.y = 5;
            p2.x = 6;
            p2.y = 5;
            var battleship = new Ship(p1, p2);
            
            p1.x = 9;
            p1.y = 5;
            p2.x = 9;
            p2.y = 8;
            var destroyer = new Ship(p1, p2);

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
            bool ok = false;
            foreach (var ship in Fleet)
            {
                if (ship.Spaces.ContainsKey(attack))
                {
                    ok = true;
                    ship.Spaces.Remove(attack);
                    if(ship.Spaces.Count() > 0)
                    {
                        result = "hit";
                    }
                    else
                    {
                        Fleet.Remove(ship);
                        if(Fleet.Count() > 0)
                        {
                            result = "sink";
                        }
                        else
                        {
                            result = "surrender";
                        }
                    }
                }
            }
            if(ok == false)
            {
                result = "miss";
            }

            //if (map.ContainsKey(attack))
            //{
            //    map[attack] = false; 
            //}
            //else
            //{
            //    result = "miss";
            //}

            return result;
        }
    }
}
