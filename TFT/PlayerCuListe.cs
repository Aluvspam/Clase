using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class PlayerCuListe : IPlayer
    {
        public Moves FirstMove()
        {
            throw new NotImplementedException();
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            MetodaCuListe(myLastMove, othersLastMove);
            throw new NotImplementedException();
        }

        void MetodaCuListe(Moves myLastMove, Moves othersLastMove)
        {
            //initializare lista
            var myList = new List<Moves>();
            var mySecondList = new List<Moves>();
            //adaug elemente in lista
            myList.Add(myLastMove);
            mySecondList.Add(othersLastMove);
            //nr elemente liste
            Console.WriteLine(myList.Count);
            Console.WriteLine(mySecondList.Count);
            //clone list and save into new list
            List<Moves> newList = new List<Moves>(myList);
            //remove some elements from list
            newList.RemoveRange(0, 10);//replace 10 with what you need, variable or number
            //accesare element
            Console.WriteLine(newList[0]);
            //comparare elemente
            if (newList[0] == newList[1])
            {
                //Do something to win game
            }
        }
    }
}
