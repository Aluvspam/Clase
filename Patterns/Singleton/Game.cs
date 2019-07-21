using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public class Game
    {
        public int[] playerIds;
        public string TablaDeJoc;
        static Game instance;
        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }
        public Game()
        {
            playerIds = new int[] { 1, 2 };
            TablaDeJoc = "TablaDeJocGoala";
        }
    }
}
