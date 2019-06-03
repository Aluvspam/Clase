using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class DianaPlayer : IPlayer, IScore
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }

        Random val;

        public DianaPlayer()
        {
            val = new Random();
        }


        public Moves FirstMove()
        {
            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (myLastMove == Moves.C && othersLastMove == Moves.C)
            {
                return Moves.C;
            }
            else
            {
                return Moves.D;
            }
        }

        public List<string> MoveALot()
        {
            List<string> correctMoves = new List<string>(); // B-B B-C B-D C-B C-C C-D D-B D-C D-D
            for (int i = 0; i < Enum.GetNames(typeof(Moves)).Length; i++)
            {
                string temp = Enum.GetNames(typeof(Moves))[i];
                for (int j = 0; j < Enum.GetNames(typeof(Moves)).Length; j++)
                {
                    string move = temp + '-' + Enum.GetNames(typeof(Moves))[j];
                    correctMoves.Add(move);
                }
            }
            return correctMoves;


        }
    }
}
