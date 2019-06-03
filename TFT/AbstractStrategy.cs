using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    abstract class AbstractStrategy
    {
        public abstract Moves MoveLikeABoss(AbstractTFTPlayer player);
        public virtual Moves FirstMove()
        {
            return Moves.C;
        }
    }
}
