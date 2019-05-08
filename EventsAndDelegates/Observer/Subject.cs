using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    class Subject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double eur;
        public double Eur
        {
            get { return eur; }
            set
            {
                eur = value;
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Eur"));
                }
            }
        }

       
    }
}
