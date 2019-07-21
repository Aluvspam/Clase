using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class RunExamples
    {
        public static void Run()
        {
            var s = new Subject();
            //var o1 = new Observer1();
            var o2 = new Observer2();

            s.PropertyChanged += S_PropertyChanged;

            s.Eur = 4.55;
        }

        private static void S_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("main method!!!");
        }
    }
}
