using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.Leg = 4;
            t.Sleep();
            t.Walk();
            t.YSNL();

            Cat c = new Cat();
            c.Leg = 4;
            c.Sleep();
            c.Walk();
            c.YSNL();
            c.ZLS();

            Eagle e = new Eagle();
            e.Leg = 2;
            e.Sleep();
            e.Fly();

            Console.ReadKey();
        }
    }
}
