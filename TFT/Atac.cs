﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class Atac : AbstractStrategy
    {
        public override Moves MoveLikeABoss(AbstractTFTPlayer player)
        {
            return Moves.D;
        }
        public override Moves FirstMove()
        {
            return Moves.D;
        }
    }
}
