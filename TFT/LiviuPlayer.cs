using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class LiviuPlayer : IScore, IPlayer
    {
        public int Score
        {
            get
            {
                return 0;
            }
        }

        public LiviuPlayer()
        {
            Random value;
            value = new Random();
        }

        public Moves FirstMove()
        {
            return Moves.C;
        }


        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return Moves.B;
        }

        public List<string> MoveALot()
        {
            List<string> correctMoves = new List<string>();
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
