using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class EventSubscriber
    {
        public void OnXevent(int x)
        {
            Console.WriteLine("gaby" + x);
        }

        public void OnOanaXevent(int i)
        {
            Console.WriteLine("Oana " + i);
        }

        public virtual void XeventSubscriber()
        {
            ExampleEvent.Xevent += OnXevent;
            ExampleEvent.Xevent += OnOanaXevent;
            ExampleEvent.Xevent += OnDanielXevent;
        }

        public void OnDanielXevent(int d)
        {
            Console.WriteLine("Daniel " + d);
        }
    }
}
