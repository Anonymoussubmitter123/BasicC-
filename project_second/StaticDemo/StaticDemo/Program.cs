using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            //Person.address = "云南";
            p1.name = "wlq";
            p1.P1();
            Console.WriteLine(p1.name + Person.address + p1.Name + Person.Address);
            
            Person p2 = new Person();
            p2.name = "111";
            Console.WriteLine(p2.name + p2.Name + Person.Address);
            Person.P2();

            Console.WriteLine(Monkey.Name);
            Monkey.Hello();

            Console.ReadKey();
        }
    }
}
