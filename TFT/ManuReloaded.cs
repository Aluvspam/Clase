using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class ManuReloaded : IPlayer, IScore
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }
        Random rnd;
        public ManuReloaded()
        {
            rnd = new Random();

        }
        public Moves FirstMove()
        {

            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.D)
            {
                return Moves.C;
            }
            else if (myLastMove == Moves.B && othersLastMove == Moves.C)
            {
                return Moves.C;
            }
            else if (myLastMove == Moves.C && othersLastMove == Moves.D)
            {
                return Moves.D;
            }

            else
            {
                return Moves.D;
            }



            private Moves ManuReloaded()

            {
                return ((new Random()).Next(2) == 0) ? Moves.C : Moves.D;
            }
        }
    } }
