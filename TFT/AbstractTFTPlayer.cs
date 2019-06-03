using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public delegate void BossDelegate();

    abstract class AbstractTFTPlayer : IPlayer
    {
        public static event BossDelegate event1;
        public static event BossDelegate event2;
        public Moves myLastMove;
        public Moves hisLastMove;
        protected int moves;
        protected bool flag;

        protected AbstractStrategy strategy;

        public AbstractTFTPlayer()
        {

        }

        public virtual Moves FirstMove()
        {
            moves++;
            return Moves.C;
        }
        protected bool Invoke(Ids ids)
        {
            if (ids == Ids.id1 && event1 != null)
            {
                //WhenIInvoke1();
                event1.Invoke();
                return true;//returnez rezultatul actiunii
            }
            else if (ids == Ids.id2 && event2 != null)
            {
                event2.Invoke();
                return true;
            }
            return false;
        }
        public virtual Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var result = (othersLastMove == Moves.B) ? Moves.D : othersLastMove;
            return result;
        }
        protected virtual void Event1Handler()//invoc daca nu e null
        {
            if (event2 != null)
            {
                event2.Invoke();
            }
            Unsubscribe(Ids.id1);
        }
        protected virtual void Event2Handler()
        {
            if (event1 != null)
            {
                event1.Invoke();
            }
            Unsubscribe(Ids.id2);
        }
        /// <summary>
        /// method that helps classes that inherits this class to subscribe to events
        /// </summary>
        /// <param name="n">number of the event to subscribe to</param>
        /// <param name="a">the delegate you wish to subscribe to the event</param>
        public void Subscribe(Ids ids, BossDelegate a)
        {
            if (ids == Ids.id1)
            {
                event1 += a;
            }
            else if (ids == Ids.id2)
            {
                event2 += a;
            }
        }
        protected void Unsubscribe(Ids ids)
        {
            if (ids == Ids.id1 && event1 != null)
            {
                event1 -= (BossDelegate)(event1.GetInvocationList())[0];
            }
            else if (ids == Ids.id2 && event2 != null)
            {
                event2 -= (BossDelegate)(event2.GetInvocationList())[0];
            }
        }
        protected void StoreMoves(Moves myLastMove, Moves othersLastMove)
        {
            this.myLastMove = myLastMove;
            hisLastMove = othersLastMove;
            moves++;
        }
        //protected virtual void WhenIInvoke1()
        //{
        //}
    }
}
