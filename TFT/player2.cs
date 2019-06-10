using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Player2 : AbstractTFTPlayer
    {
        public Player2()
        {
            strategy = new Atac();
        }
        public override Moves FirstMove()
        {
            strategy = new Atac();
            Subscribe(Ids.id1, Event1Handler);
            Invoke(Ids.id2);
            moves = 1;
            flag = false;
            return strategy.FirstMove();
        }

        protected override void Event1Handler()
        {
            if (!flag)
            {
                strategy = new Capra();
                flag = true;
                base.Event1Handler();
            }
        }
        public override Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if (moves == 1)
            {
                Unsubscribe(Ids.id1);
            }
            StoreMoves(myLastMove, othersLastMove);
            return strategy.MoveLikeABoss(this);
        }
    }
}
