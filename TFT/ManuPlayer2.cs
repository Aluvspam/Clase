using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class ManuPlayer2 : IPlayer, IScore
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }
        Random rnd;
        public ManuPlayer2()
        {
            rnd = new Random();

        }
        public Moves FirstMove()
        {

            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {

            if (othersLastMove == Moves.D)
            {
                return Moves.D;
            }
            if (othersLastMove == Moves.C)
            {
                return Moves.D;
            }
            if (othersLastMove == Moves.B)
            {
                return Moves.D;
            }
            return Moves.D;
        }

        private Moves RandomMove()
        {
            return (rnd.Next(2) == 0) ? Moves.C : Moves.D;
        }
    }
}
