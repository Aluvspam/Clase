using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Teo : IPlayer, IScore
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }
        Random rnd;
        public Teo1()
        {
            rnd = new Random();
        }
        public Moves FirstMove()
        {
            return Moves.D;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (othersLastMove == Moves.D)
                return Moves.D;
            else
                return Moves.C;
        }

        private Moves RandomMove()
        {
            return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        }
    }
}