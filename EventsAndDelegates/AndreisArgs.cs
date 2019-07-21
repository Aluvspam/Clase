using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class AndreisArgs : EventArgs
    {
        public AndreisArgs(double d)
        {
            score = d;
        }
        double score;
    }
}
